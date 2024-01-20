namespace ATMConsoleApp.Models
{
    class ATMTransactionLog : ATMBaseLog
    {
        public ATMTransactionLog()
        {
            LogType = ATMLogTypeEnum.Transaction;
        }
        public string SentAccountIBAN { get; set; } = null!;
        public string ReceivedAccountIBAN { get; set; } = null!;
        public decimal SentMoney { get; set; }

    }
}