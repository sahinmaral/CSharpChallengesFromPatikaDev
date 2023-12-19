Console.Write("Enter message to be reversed: ");
string message = Console.ReadLine();

if (string.IsNullOrEmpty(message))
{
    Console.WriteLine("You have to write something");
    return;
}

string reverseStringNormally(string message)
{
    string[] splittedMessage = message.Split(" ");

    string[] newSplittedMessage = new string[splittedMessage.Length];

    string newMessage;
    for (int i = 0; i < splittedMessage.Length; i++)
    {
        string currentReversedMessage = "";

        for (int j = splittedMessage[i].Length; j > 0; j--)
        {
            var character = splittedMessage[i].Substring(j - 1, 1);
            currentReversedMessage += character;
        }

        newSplittedMessage[i] = currentReversedMessage;
    }

    return string.Join(" ", newSplittedMessage);
}


//Replaces the characters in the given string expression with the previous character
string reverseStringByDesiredAlgorithm(string message)
{
    string[] splittedMessage = message.Split(" ");

    string[] newSplittedMessage = new string[splittedMessage.Length];

    for (int i = 0; i < splittedMessage.Length; i++)
    {
        string currentReversedMessage = "";

        for (int j = 0; j < splittedMessage[i].Length; j++)
        {
            if (j == 0) continue;
            else
            {
                var character = splittedMessage[i].Substring(j, 1);
                currentReversedMessage += character;
            }
        }

        currentReversedMessage += splittedMessage[i].Substring(0, 1);

        newSplittedMessage[i] = currentReversedMessage;
    }

    return string.Join(" ", newSplittedMessage);
}

Console.WriteLine($"New reversed message : {reverseStringNormally(message)}"); 
Console.WriteLine($"New reversed message by desired algorithm : {reverseStringByDesiredAlgorithm(message)}");