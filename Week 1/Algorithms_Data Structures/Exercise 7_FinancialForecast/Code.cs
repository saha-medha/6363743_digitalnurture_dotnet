using System;

class FinancialForecast
{
    static void Main()
    {
        Console.Write("Enter initial investment amount: ");
        if (!double.TryParse(Console.ReadLine(), out double initialValue) || initialValue < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number.");
            return;
        }

        Console.Write("Enter annual growth rate (in %): ");
        if (!double.TryParse(Console.ReadLine(), out double growthRatePercent))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }
        double growthRate = growthRatePercent / 100.0;

        Console.Write("Enter number of years to forecast: ");
        if (!int.TryParse(Console.ReadLine(), out int years) || years < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive integer.");
            return;
        }

        double futureValue = initialValue * Math.Pow(1 + growthRate, years);

        Console.WriteLine($"\nForecasted Value after {years} years: {futureValue:C2}");
}
}
