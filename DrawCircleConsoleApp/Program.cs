Console.Write("Enter radius of circle: ");
string radiusOfCircle = Console.ReadLine();

if (string.IsNullOrEmpty(radiusOfCircle))
{
    Console.WriteLine("You have to write any radius");
    return;
}else if (radiusOfCircle.Contains('.'))
{
    Console.WriteLine("Radius of circle must be integer");
    return;
}

int convertedRadiusOfCircle = Convert.ToInt16(radiusOfCircle);
if (convertedRadiusOfCircle <= 1)
{
    Console.WriteLine("You have to write radius greater than one");
    return;
}


for (int i = -convertedRadiusOfCircle; i <= convertedRadiusOfCircle; i++)
{
    for (int j = -convertedRadiusOfCircle; j <= convertedRadiusOfCircle; j++)
    {
        if (i * i + j * j <= convertedRadiusOfCircle * convertedRadiusOfCircle)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}