Console.WriteLine("Enter numbers: ");
Console.WriteLine("Numbers should be: ");
Console.WriteLine("-> 1 2");
Console.WriteLine("-> 1 2 3 4");
Console.WriteLine("And count of numbers must be multiplied by 2");

string numbersOfEntered = Console.ReadLine();

if (string.IsNullOrEmpty(numbersOfEntered))
{
    Console.WriteLine("You have to write numbers");
    return;
}

string[] splittedNumbers = numbersOfEntered.Trim().Split(" ");
int[] parsedNumbers = new int[splittedNumbers.Length];

string[] newNumbers = new string[splittedNumbers.Length / 2];

for (int i = 0; i < splittedNumbers.Length; i++)
{
    bool isParsedNumberInteger = int.TryParse(splittedNumbers[i], out int parsedNumber);
    if (!isParsedNumberInteger)
    {
        Console.WriteLine("You have to write integer as number");
        return;
    }

    parsedNumbers[i] = parsedNumber;
}

for (int i = 0; i < parsedNumbers.Length; i += 2)
{
    if (parsedNumbers[i] == parsedNumbers[i + 1])
    {
        newNumbers[i == 0 ? 0 : i / 2] = Math.Pow(parsedNumbers[i] * parsedNumbers[i + 1], 2).ToString();
    }
    else
    {
        newNumbers[i == 0 ? 0 : i / 2] = (parsedNumbers[i] + parsedNumbers[i + 1]).ToString();
    }
}

Console.WriteLine($"{string.Join(" ",newNumbers)}");