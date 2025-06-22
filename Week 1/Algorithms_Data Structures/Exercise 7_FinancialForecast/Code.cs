using System;

class Program
{

    public static double ForecastFutureValueRecursive(double initialAmount, double growthRate, int years)
    {
        if (years == 0)
            return initialAmount;

        return (1 + growthRate) * ForecastFutureValueRecursive(initialAmount, growthRate, years - 1);
    }
    public static double ForecastFutureValueIterative(double initialAmount, double growthRate, int years)
    {
        double result = initialAmount;
        for (int i = 0; i < years; i++)
        {
            result *= (1 + growthRate);
        }
        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Financial Forecasting Tool ===");

        double initialAmount = 10000;          
        double annualGrowthRate = 0.10;        
        int years = 5;                           

        double futureValueRecursive = ForecastFutureValueRecursive(initialAmount, annualGrowthRate, years);

        double futureValueIterative = ForecastFutureValueIterative(initialAmount, annualGrowthRate, years);

        Console.WriteLine($"\nInitial Amount: ₹{initialAmount}");
        Console.WriteLine($"Annual Growth Rate: {annualGrowthRate * 100}%");
        Console.WriteLine($"Forecast Period: {years} years");

        Console.WriteLine($"\n Recursive Forecast Result: ₹{Math.Round(futureValueRecursive, 2)}");
        Console.WriteLine($"Iterative Forecast Result: ₹{Math.Round(futureValueIterative, 2)}");
    }
}
