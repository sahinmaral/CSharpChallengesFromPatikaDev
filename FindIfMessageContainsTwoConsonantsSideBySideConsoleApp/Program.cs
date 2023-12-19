string[] consonantsOfTurkishAlphabet = new string[]
{
    "z", "y", "v", "t", "ş", "s", "r", "p", "n", "r", "m", "l", "k", "h", "j", "ğ", "g", "d", "ç", "c", "b"
};

Console.Write("Enter message : ");
string message = Console.ReadLine();

if (string.IsNullOrEmpty(message))
{
    Console.WriteLine("You have to write something");
    return;
}

string findConsonants(string message)
{
    string[] splittedMessage = message.Split(" ");

    string[] newSplittedMessage = new string[splittedMessage.Length];

    for (int i = 0; i < splittedMessage.Length; i++)
    {
        var currentMessage = splittedMessage[i];

        bool isConsonantsFoundSideBySide = false;

        for (int j = 0; j < currentMessage.Length; j++)
        {
            if (j == currentMessage.Length - 1) continue;

            var currentCharacter = currentMessage.Substring(j, 1);
            var nextCharacter = currentMessage.Substring(j+1, 1);

            if(consonantsOfTurkishAlphabet.Contains(currentCharacter) && consonantsOfTurkishAlphabet.Contains(nextCharacter))
            {
                isConsonantsFoundSideBySide = true;
                break;
            } 
        }

        newSplittedMessage[i] = isConsonantsFoundSideBySide ? "True" : "False";
    }

    return string.Join(" ", newSplittedMessage);
}

Console.WriteLine(findConsonants(message));