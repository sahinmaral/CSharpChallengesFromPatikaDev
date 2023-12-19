//Check whether the n numbers entered on the screen are less than or
//greater than 67. Write a console application that calculates the sum
//of the differences of the numbers that are less than 67 and the difference
//between 67 and the squares of the differences that are greater than 67,
//and prints them on the screen.

Console.WriteLine("Enter numbers: ");
Console.WriteLine("Numbers should be: ");
Console.WriteLine("-> 1");
Console.WriteLine("-> 1,2,3,4");

string numbersOfEntered = Console.ReadLine();

if (string.IsNullOrEmpty(numbersOfEntered))
{
    Console.WriteLine("You have to write numbers");
    return;
}

if (!numbersOfEntered.Contains(','))
{
    bool isParsedNumberInteger = int.TryParse(numbersOfEntered, out int parsedNumber);
    if (!isParsedNumberInteger)
    {
        Console.WriteLine("You have to write integer as number");
        return;
    }

    Console.WriteLine(parsedNumber);
}
else
{
    string[] splittedNumberStrings = numbersOfEntered.Split(",");
    int[] convertedNumbers = new int[splittedNumberStrings.Length];

    List<int> numbersWhichLessThanSixtySeven = new List<int>();
    List<int> numbersWhichGreaterSixtySeven = new List<int>();

    for (int i = 0; i < splittedNumberStrings.Length; i++)
    {
        bool isParsedNumberInteger = int.TryParse(splittedNumberStrings[i], out int parsedNumber);
        if (!isParsedNumberInteger)
        {
            Console.WriteLine("One of the numbers you wrote is not integer");
            return;
        }
        else
        {
            convertedNumbers[i] = parsedNumber;
            if(parsedNumber < 67)
            {
                numbersWhichLessThanSixtySeven.Add(parsedNumber);
            }
            else if(parsedNumber > 67)
            {
                numbersWhichGreaterSixtySeven.Add(parsedNumber);
            }
        }
    }

    int sumOfNumbersWhichLessThanSixtySeven = numbersWhichLessThanSixtySeven.Select((number) =>
    {
        return 67 - number;
    }).Sum();

    int sumOfNumbersWhichGreaterThanSixtySeven = numbersWhichGreaterSixtySeven.Select((number) =>
    {
        return Convert.ToInt32(Math.Pow(67 - number, 2));
    }).Sum();

    Console.WriteLine($"{sumOfNumbersWhichLessThanSixtySeven} {sumOfNumbersWhichGreaterThanSixtySeven}");
}