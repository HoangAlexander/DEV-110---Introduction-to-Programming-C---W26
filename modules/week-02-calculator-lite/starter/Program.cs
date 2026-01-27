/**************************************************************
* Course: DEV 110
* Term: Winter 2026
*
* Programmer: Alexander Hoang
* Assignment: Calculator Lite
*
* Description:
* Read the user's name and display it back to them while taking their 2 values and displaying the results for
* addition, subtraction, multiplication, division, remainder, average, and percentage difference.
*
**************************************************************/

namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");

        Console.WriteLine("Before we begin, please enter your name:");
        string userName = Console.ReadLine();
        Console.WriteLine($"Hello, {userName}!\n Thank you for using the Calculator Lite today.\n");

        Console.WriteLine("For your calculation would you be using decimal precision? (yes/no):");
        string decimalChoice = Console.ReadLine().ToLower();
        bool useDecimals = decimalChoice == "yes";

        double num1, num2;

        if (useDecimals)
        {
            Console.WriteLine("Please enter your first number (decimal):");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second number (decimal):");
            num2 = double.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Please enter your first number (whole number):");
            num1 = (double)int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your second number (whole number):");
            num2 = (double)int.Parse(Console.ReadLine());
        }

        double sum = num1 + num2;
        double difference = num1 - num2;
        double product = num1 * num2;

        Console.WriteLine("\n===============\n");
        Console.WriteLine($"\nHere are the results for {userName}:");
        Console.WriteLine("\n===============\n");
        Console.WriteLine($"Sum: {sum:F2}");
        Console.WriteLine($"Difference: {difference:F2}");
        Console.WriteLine($"Product: {product:F2}");
        if (num2 != 0)
        {
            double quotient = num1 / num2;
            double remainder = num1 % num2;
            Console.WriteLine($"Quotient: {quotient:F2}");
            Console.WriteLine($"Remainder: {remainder:F2}");
        }
        else
        {
            Console.WriteLine("Quotient: Error - Undefined due to dividing by zero!");
            Console.WriteLine("Remainder: Error - Undefined due to dividing by zero!");
        }
        double average = (num1 + num2) / 2;
        Console.WriteLine($"Average: {average:F2}");
        Console.WriteLine($"\nPerformed 6 calculations for {userName}!");
        if (num1 != 0)
        {
            double percentageDifference = ((num1 - num2) / num1) * 100;
            Console.WriteLine($"Percentage Difference: {percentageDifference:F2}%");
        }
        else
        {
            Console.WriteLine("Percentage Difference: Error - Undefined due to dividing by zero!");
        }
        Console.WriteLine("\nThank you for using Calculator Lite!");
    }
}
