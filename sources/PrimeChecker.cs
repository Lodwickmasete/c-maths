using System;

public class PrimeChecker
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Prime Number Checker");

        Console.Write("Enter an integer greater than 1: ");
        if (!int.TryParse(Console.ReadLine(), out int number) || number <= 1)
        {
            Console.WriteLine("Invalid input. Please enter an integer greater than 1.");
            return;
        }

        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(number); i++) // Only check up to the square root
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            Console.WriteLine($"{number} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime number.");
        }

        Console.ReadKey();
    }
}
