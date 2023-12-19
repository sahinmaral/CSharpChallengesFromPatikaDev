Console.Write("Enter distance of edge: ");
string distanceOfEdge = Console.ReadLine();

if (string.IsNullOrEmpty(distanceOfEdge))
{
    Console.WriteLine("You have to write any distance of edge");
    return;
}else if (distanceOfEdge.Contains('.'))
{
    Console.WriteLine("Distance must be integer");
    return;
}


int convertedDistanceOfEdge = Convert.ToInt16(distanceOfEdge);
if (convertedDistanceOfEdge <= 1)
{
    Console.WriteLine("You have to write any distance greater than one");
    return;
}

for (int i = 1; i <= convertedDistanceOfEdge; i++)
{
    for (int j = 1; j <= convertedDistanceOfEdge - i; j++)
    {
        Console.Write(" ");
    }
    for (int j = 1; j <= 2 * i - 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}