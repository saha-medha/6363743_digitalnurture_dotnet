using System;

class Program
{
    // Recursive method to forecast future value
    public static double ForecastFutureValueRecursive(double initialAmount, double growthRate, int years)
    {
        if (years == 0)
            return initialAmount;

        return (1 + growthRate) * ForecastFutureValueRecursive(initialAmount, growthRate, years - 1);
    }

    // Iterative method to forecast future value (optimized)
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

        // Example input
        double initialAmount = 10000;           // ₹10,000
        double annualGrowthRate = 0.10;         // 10% growth
        int years = 5;                           // forecast for 5 years

        // Recursive forecast
        double futureValueRecursive = ForecastFutureValueRecursive(initialAmount, annualGrowthRate, years);

        // Iterative forecast
        double futureValueIterative = ForecastFutureValueIterative(initialAmount, annualGrowthRate, years);

        // Output
        Console.WriteLine($"\nInitial Amount: ₹{initialAmount}");
        Console.WriteLine($"Annual Growth Rate: {annualGrowthRate * 100}%");
        Console.WriteLine($"Forecast Period: {years} years");

        Console.WriteLine($"\n Recursive Forecast Result: ₹{Math.Round(futureValueRecursive, 2)}");
        Console.WriteLine($"Iterative Forecast Result: ₹{Math.Round(futureValueIterative, 2)}");
    }
}
