Console.Write("Enter message to be reversed: ");
string message = Console.ReadLine();

if (string.IsNullOrEmpty(message))
{
    Console.WriteLine("You have to write something");
    return;
}

string reverseStringByDesiredAlgorithm(string message)
{
    string[] splittedMessage = message.Split(" ");

    string[] newSplittedMessage = new string[splittedMessage.Length];

    for (int i = 0; i < splittedMessage.Length; i++)
    {
        string currentReversedMessage = "";

        for (int j = 0; j < splittedMessage[i].Length; j++)
        {
            if (j == 0)
            {
                currentReversedMessage += splittedMessage[i].Substring(splittedMessage[i].Length-1, 1);
                newSplittedMessage[i] = currentReversedMessage;
            }
            else if (j == splittedMessage[i].Length - 1)
            {
                currentReversedMessage += splittedMessage[i].Substring(0, 1);
                newSplittedMessage[i] = currentReversedMessage;
            }
            else
            {
                var character = splittedMessage[i].Substring(j, 1);
                currentReversedMessage += character;
            }
        }


    }

    return string.Join(" ", newSplittedMessage);
}

Console.WriteLine($"New reversed message by desired algorithm : {reverseStringByDesiredAlgorithm(message)}");