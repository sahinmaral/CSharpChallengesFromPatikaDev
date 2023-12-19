

Console.WriteLine("Choose a geometric shape you want to calculate: ");
Console.WriteLine("-> 1.Circle");
Console.WriteLine("-> 2.Square");
Console.WriteLine("-> 3.Rectangle");
Console.WriteLine("-> 4.Equilateral Triangle");

string enteredInput = Console.ReadLine();

if (string.IsNullOrEmpty(enteredInput))
{
    Console.WriteLine("You have to write something");
    return;
}

bool isEnteredInputInteger = int.TryParse(enteredInput, out int parsedNumber);
if (!isEnteredInputInteger)
{
    Console.WriteLine("You have to write integer for input");
    return;
}

switch (parsedNumber)
{
    case 1: Circle(); break;
    case 2: Square(); break;
    case 3: Rectangle(); break;
    case 4: Triangle(); break;
    default:
        Console.WriteLine("You have to write input between 1 and 4");
        return;
}

void Triangle()
{
    Console.WriteLine("What do you want to calculate: ");
    Console.WriteLine("-> 1. Area");
    Console.WriteLine("-> 2. Perpendicular");

    string enteredInput = Console.ReadLine();

    if (string.IsNullOrEmpty(enteredInput))
    {
        Console.WriteLine("You have to write something");
        return;
    }

    bool isEnteredInputInteger = int.TryParse(enteredInput, out int parsedNumberToCalculate);
    if (!isEnteredInputInteger)
    {
        Console.WriteLine("You have to write integer as input");
        return;
    }

    Console.Write("Enter one of the edge: ");
    string enteredEdge = Console.ReadLine();

    if (string.IsNullOrEmpty(enteredEdge))
    {
        Console.WriteLine("You have to write something for edge");
        return;
    }

    bool isEnteredEdgeInteger = int.TryParse(enteredEdge, out int parsedNumberEdge);
    if (!isEnteredEdgeInteger)
    {
        Console.WriteLine("You have to write integer for edge");
        return;
    }
    else if (parsedNumberEdge < 0)
    {
        Console.WriteLine("Edge must be greater than zero");
        return;
    }

    double height = (parsedNumberEdge / 2) * Math.Sqrt(2);

    if (parsedNumberToCalculate == 1)
    {
        Console.WriteLine($"Area of equilateral triangle = {(height * parsedNumberEdge) / 2}");
    }
    else if (parsedNumberToCalculate == 2)
    {
        Console.WriteLine($"Perpendicular of equilateral triangle = {parsedNumberEdge * 3}");
    }
    else
    {
        Console.WriteLine("You have to write between 1 and 2");
        return;
    }
}

void Rectangle()
{
    Console.WriteLine("What do you want to calculate: ");
    Console.WriteLine("-> 1. Area");
    Console.WriteLine("-> 2. Perpendicular");

    string enteredInput = Console.ReadLine();

    if (string.IsNullOrEmpty(enteredInput))
    {
        Console.WriteLine("You have to write something");
        return;
    }

    bool isEnteredInputInteger = int.TryParse(enteredInput, out int parsedNumberToCalculate);
    if (!isEnteredInputInteger)
    {
        Console.WriteLine("You have to write integer as input");
        return;
    }

    Console.Write("Enter first edge: ");
    string enteredFirstEdge = Console.ReadLine();

    if (string.IsNullOrEmpty(enteredFirstEdge))
    {
        Console.WriteLine("You have to write something for first edge");
        return;
    }

    bool isEnteredFirstEdgeInteger = int.TryParse(enteredFirstEdge, out int parsedNumberFirstEdge);
    if (!isEnteredFirstEdgeInteger)
    {
        Console.WriteLine("You have to write integer for first edge");
        return;
    }
    else if (parsedNumberFirstEdge < 0)
    {
        Console.WriteLine("First edge must be greater than zero");
        return;
    }

    Console.Write("Enter second edge: ");
    string enteredSecondEdge = Console.ReadLine();

    if (string.IsNullOrEmpty(enteredSecondEdge))
    {
        Console.WriteLine("You have to write something for second edge");
        return;
    }

    bool isEnteredSecondEdgeInteger = int.TryParse(enteredSecondEdge, out int parsedNumberSecondEdge);
    if (!isEnteredSecondEdgeInteger)
    {
        Console.WriteLine("You have to write integer for second edge");
        return;
    }
    else if (parsedNumberSecondEdge < 0)
    {
        Console.WriteLine("Second edge must be greater than zero");
        return;
    }

    if (parsedNumberToCalculate == 1)
    {
        Console.WriteLine($"Area of rectangle = {parsedNumberFirstEdge * parsedNumberSecondEdge}");
    }
    else if (parsedNumberToCalculate == 2)
    {
        Console.WriteLine($"Perpendicular of rectangle = {2 * (parsedNumberFirstEdge + parsedNumberSecondEdge)}");
    }
    else
    {
        Console.WriteLine("You have to write between 1 and 2");
        return;
    }
}

void Square()
{
    Console.WriteLine("What do you want to calculate: ");
    Console.WriteLine("-> 1. Area");
    Console.WriteLine("-> 2. Perpendicular");

    string enteredInput = Console.ReadLine();

    if (string.IsNullOrEmpty(enteredInput))
    {
        Console.WriteLine("You have to write something");
        return;
    }

    bool isEnteredInputInteger = int.TryParse(enteredInput, out int parsedNumberToCalculate);
    if (!isEnteredInputInteger)
    {
        Console.WriteLine("You have to write integer as input");
        return;
    }

    Console.Write("Enter one of the edge: ");
    string enteredEdge = Console.ReadLine();

    if (string.IsNullOrEmpty(enteredEdge))
    {
        Console.WriteLine("You have to write something for edge");
        return;
    }

    bool isEnteredEdgeInteger = int.TryParse(enteredEdge, out int parsedNumberEdge);
    if (!isEnteredEdgeInteger)
    {
        Console.WriteLine("You have to write integer for edge");
        return;
    }
    else if (parsedNumberEdge < 0)
    {
        Console.WriteLine("Edge must be greater than zero");
        return;
    }

    if (parsedNumberToCalculate == 1)
    {
        Console.WriteLine($"Area of square = {parsedNumberEdge * parsedNumberEdge}");
    }
    else if (parsedNumberToCalculate == 2)
    {
        Console.WriteLine($"Perpendicular of square = {2 * (parsedNumberEdge + parsedNumberEdge)}");
    }
    else
    {
        Console.WriteLine("You have to write between 1 and 2");
        return;
    }
}

void Circle()
{
    Console.WriteLine("What do you want to calculate: ");
    Console.WriteLine("-> 1. Area");
    Console.WriteLine("-> 2. Perpendicular");

    string enteredInput = Console.ReadLine();

    if (string.IsNullOrEmpty(enteredInput))
    {
        Console.WriteLine("You have to write something");
        return;
    }

    bool isEnteredInputInteger = int.TryParse(enteredInput, out int parsedNumberToCalculate);
    if (!isEnteredInputInteger)
    {
        Console.WriteLine("You have to write integer for input");
        return;
    }

    Console.Write("Enter radius: ");
    string radiusInput = Console.ReadLine();

    if (string.IsNullOrEmpty(radiusInput))
    {
        Console.WriteLine("You have to write something for radius");
        return;
    }

    bool isEnteredRadiusInputInteger = int.TryParse(radiusInput, out int radius);
    if (!isEnteredRadiusInputInteger)
    {
        Console.WriteLine("You have to write integer for radius");
        return;
    }
    else if (radius < 0)
    {
        Console.WriteLine("Radius must be greater than zero");
        return;
    }


    if (parsedNumberToCalculate == 1)
    {
        Console.WriteLine($"Area of circle = {Math.PI * Math.Pow(radius, 2)}");
    }
    else if (parsedNumberToCalculate == 2)
    {
        Console.WriteLine($"Perpendicular of circle = {Math.PI * 2 * radius}");
    }
    else
    {
        Console.WriteLine("You have to write between 1 and 2");
        return;
    }

}