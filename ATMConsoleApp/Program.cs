﻿using System.Text.Json;

namespace ATMConsoleApp
{
    class Program
    {
        private static List<BankAccount> _bankAccounts;
        private static BankAccount _currentBankAccount;
        static void Main()
        {
            try
            {
                LoadData();

                Console.WriteLine("Welcome to ATM");

                ShowStartupMenu();
            }
            catch (Exception ex)
            {
                SendMessage(ex.Message, MessageTypeEnum.Error);
            }
        }
        private static void SendMessage(string message, MessageTypeEnum messageType)
        {
            ConsoleColor originalColor = Console.ForegroundColor;

            switch (messageType)
            {
                case MessageTypeEnum.Success:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case MessageTypeEnum.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case MessageTypeEnum.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    break;
            }


            Console.WriteLine(message);
            Console.ForegroundColor = originalColor;
        }
        private static void ShowStartupMenu()
        {
            Console.WriteLine("1 -) Login");
            Console.WriteLine("2 -) Exit");

            string[] validKeys = ["1", "2"];

            while (true)
            {

                Console.Write("What would you like to process: ");
                string key = Console.ReadLine().Trim();

                if (!validKeys.Contains(key))
                {
                    SendMessage("Invalid key, try again.", MessageTypeEnum.Error);
                }
                else
                {
                    switch (key)
                    {
                        case "1":
                            ShowLoginMenu();
                            break;
                        case "2":
                            Environment.Exit(0);
                            break;
                    }
                }
            }


        }
        private static void ShowLoginMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("To login, please enter your IBAN and password.");
            Console.Write("IBAN: ");
            string iban = Console.ReadLine().Trim();
            Console.Write("Password: ");
            string password = Console.ReadLine().Trim();

            BankAccount? foundBankAccount = _bankAccounts.Find(x => x.IBAN == iban);
            if (foundBankAccount is null)
            {
                SendMessage("Bank account could not found, please try again.", MessageTypeEnum.Error);
                ShowLoginMenu();
            }
            else if (foundBankAccount.Password != password)
            {
                //Send log
                SendMessage("Password is incorrect, please try again.", MessageTypeEnum.Error);
                ShowLoginMenu();
            }
            else
            {
                _currentBankAccount = foundBankAccount;

                SendMessage("You have successfully logged in", MessageTypeEnum.Success);
                ShowAppMenu();
            }
        }
        private static void ShowAppMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("1 -) Show balance");
            Console.WriteLine("2 -) Withdraw money");
            Console.WriteLine("3 -) Deposit money");
            Console.WriteLine("4 -) Transfer money");
            Console.WriteLine("5 -) Logout");

            string[] validKeys = ["1", "2", "3", "4", "5"];

            while (true)
            {
                Console.Write("What would you like to process: ");
                string key = Console.ReadLine().Trim();

                if (!validKeys.Contains(key))
                {
                    SendMessage("Invalid key, try again.", MessageTypeEnum.Error);
                }
                else
                {
                    switch (key)
                    {
                        case "1":
                            ShowBalance();
                            break;
                        case "2":
                            WithdrawMoney();
                            break;
                        case "3":
                            DepositMoney();
                            break;
                        case "4":
                            TransferMoney();
                            break;
                        case "5":
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        }
        private static void DepositMoney()
        {
            Console.WriteLine("");
            Console.WriteLine("Deposit");
            Console.Write("How much money do you want to deposit: ");
            string enteredDepositedMoney = Console.ReadLine().Trim();
            decimal depositedMoney = Convert.ToDecimal(enteredDepositedMoney);

            if (depositedMoney < 0)
            {
                SendMessage("Incorrect balance.", MessageTypeEnum.Error);
                ShowAppMenu();
            }

            _bankAccounts.Find(x => x.Id == _currentBankAccount.Id).Balance += depositedMoney;
            UpdateData();
            SendMessage($"{depositedMoney} TRY has been deposited successfully", MessageTypeEnum.Success);
            ShowAppMenu();
        }
        private static void WithdrawMoney()
        {
            Console.WriteLine("");
            Console.WriteLine("Withdraw");
            Console.Write("How much money do you want to withdraw: ");
            string enteredWithdrewMoney = Console.ReadLine().Trim();
            decimal withDrewMoney = Convert.ToDecimal(enteredWithdrewMoney);

            if (_currentBankAccount.Balance - withDrewMoney < 0)
            {
                SendMessage("Insufficient balance.", MessageTypeEnum.Error);
                ShowAppMenu();
            }

            _bankAccounts.Find(x => x.Id == _currentBankAccount.Id).Balance -= withDrewMoney;
            UpdateData();
            SendMessage($"{withDrewMoney} TRY has been withdrawn successfully", MessageTypeEnum.Success);
            ShowAppMenu();
        }
        private static void TransferMoney()
        {
            Console.WriteLine("");
            Console.WriteLine("Transfer");
            Console.Write("Enter the IBAN number of the account to which you will transfer money: ");
            string iban = Console.ReadLine().Trim();

            BankAccount? foundBankAccount = _bankAccounts.Find(x => x.IBAN == iban);
            if (foundBankAccount is null)
            {
                SendMessage("Bank account could not found.", MessageTypeEnum.Error);
                ShowAppMenu();
            }

            Console.Write("How much do you want to transfer: ");
            string enteredTransferedMoney = Console.ReadLine().Trim();
            decimal transferedMoney = Convert.ToDecimal(enteredTransferedMoney);

            if (_currentBankAccount.Balance - transferedMoney < 0)
            {
                SendMessage("Insufficient balance.", MessageTypeEnum.Error);
                ShowAppMenu();
            }

            _bankAccounts.Find(x => x.Id == _currentBankAccount.Id).Balance -= transferedMoney;
            _bankAccounts.Find(x => x.Id == foundBankAccount.Id).Balance += transferedMoney;

            UpdateData();
            SendMessage($"{enteredTransferedMoney} TRY has been transfered to {foundBankAccount.IBAN} successfully", MessageTypeEnum.Success);
            ShowAppMenu();
        }
        private static void ShowBalance()
        {
            Console.WriteLine("");
            Console.WriteLine("Balance");
            Console.WriteLine($"You have\x1b[1m {_currentBankAccount.Balance}\x1b[0m TRY"); ;
            ShowAppMenu();
        }
        private static void LoadData()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bankAccounts.json");

            if (File.Exists(filePath))
            {
                string jsonContent = File.ReadAllText(filePath);

                _bankAccounts = JsonSerializer.Deserialize<List<BankAccount>>(jsonContent);
            }
            else
            {
                throw new NullReferenceException("JSON file not found.");
            }
        }
        private static void UpdateData()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bankAccounts.json");

            string jsonContent = JsonSerializer.Serialize(_bankAccounts, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(filePath, jsonContent);
        }
    }
}