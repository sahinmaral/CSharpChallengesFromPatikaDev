Console.WriteLine("Enter message: ");
Console.WriteLine("Message should be: ");
Console.WriteLine("-> {Message1},2");
Console.WriteLine("-> {Message1},2;{Message2},0");
string message = Console.ReadLine();

if (string.IsNullOrEmpty(message))
{
    Console.WriteLine("You have to write something");
    return;
}

string removeCharacterAtString(string message)
{
    string[] splittedMessage = message.Split(",");
    bool isFirstStringInteger = int.TryParse(splittedMessage[0], out int _);
    if (isFirstStringInteger)
    {
        throw new ArgumentException("You must enter string before comma.");
    }

    bool isSecondStringInteger = int.TryParse(splittedMessage[1], out int characterIndexToBeRemoved);
    if (!isSecondStringInteger)
    {
        throw new ArgumentException("You must enter integer before comma.");
    }

    if(characterIndexToBeRemoved < 0)
    {
        throw new ArgumentException("You must enter integer greater than zero before comma.");
    }

    string messageToRemoveOneCharacter = splittedMessage[0];

    if (characterIndexToBeRemoved > messageToRemoveOneCharacter.Length)
    {
        throw new ArgumentException("Character index of removed character musn't be greater than actual message length");
    }

    string newMessage = "";

    newMessage += messageToRemoveOneCharacter.Substring(0, characterIndexToBeRemoved);
    newMessage += messageToRemoveOneCharacter.Substring(characterIndexToBeRemoved + 1);

    return newMessage;
}

try
{
    if (!message.Contains(";"))
    {
        Console.WriteLine($"New message : {removeCharacterAtString(message)}");
    }
    else
    {
        string[] splittedMessages = message.Split(";");
        string[] newMessage = new string[message.Split(";").Length];

        for (int i = 0; i < splittedMessages.Length; i++)
        {
            newMessage[i] = removeCharacterAtString(splittedMessages[i]);
        }

        Console.WriteLine($"New message : {string.Join(" ", newMessage)}");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
