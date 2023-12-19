using System.Diagnostics;


Console.Write("Enter the depth of fibonacci sum: ");
int depthOfFibonnaciSeriesSum = Convert.ToInt16(Console.ReadLine());

Dictionary<int, long> calculatedFibNumbers = new Dictionary<int, long>()
{
    {0,0},{1,1},{2,1},
};

long fibonacci(int order)
{
    if (order >= 0 && order <= 2)
    {
        return calculatedFibNumbers[order];
    }
    else
    {
        long previousTwoFibonnaci = calculatedFibNumbers.ContainsKey(order - 2) ?
            calculatedFibNumbers[order - 2] : fibonacci(order - 2);

        if (!calculatedFibNumbers.ContainsKey(order - 2))
            calculatedFibNumbers.Add(order - 2, previousTwoFibonnaci);

        long previousOneFibonnaci = calculatedFibNumbers.ContainsKey(order - 1) ?
            calculatedFibNumbers[order - 1] : fibonacci(order - 1);

        if (!calculatedFibNumbers.ContainsKey(order - 1))
            calculatedFibNumbers.Add(order - 1, previousOneFibonnaci);

        return previousOneFibonnaci + previousTwoFibonnaci;
    }
}

long fibonacciSlow(int order)
{
    if (order == 1) return 0;
    else if (order == 2 || order == 3) return 1;
    else return fibonacciSlow(order - 1) + fibonacciSlow(order - 2);
}



Stopwatch stopwatch = Stopwatch.StartNew();
long result = fibonacci(depthOfFibonnaciSeriesSum);
stopwatch.Stop();
Console.WriteLine($"Fibonacci result: {result}");
Console.WriteLine($"Time elapsed for effective fibonacci: {stopwatch.ElapsedMilliseconds} milliseconds");
Console.WriteLine("The reason why this function faster than normal version, this function wrote by obeying memoization method of dynamic programming.");

Console.WriteLine("------------------------------------------------------------------------");

calculatedFibNumbers.Clear();

stopwatch.Restart();
long resultSlow = fibonacciSlow(depthOfFibonnaciSeriesSum);
stopwatch.Stop();
Console.WriteLine($"FibonacciSlow result: {resultSlow}");
Console.WriteLine($"Time elapsed for normal fibonacci: {stopwatch.ElapsedMilliseconds} milliseconds");