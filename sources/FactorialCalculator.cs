using System;

public class FactorialCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Factorial Calculator");

        Console.Write("Enter a non-negative integer: ");
        if (!int.TryParse(Console.ReadLine(), out int number) || number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            return;
        }

        long factorial = 1; 
        for (int i = 1; i <= number; i++)
        {
            factorial *= i; 
        }

        Console.WriteLine($"{number}! = {factorial}");
        Console.ReadKey();
    }
}
