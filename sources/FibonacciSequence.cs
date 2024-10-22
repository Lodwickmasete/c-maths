using System;

public class FibonacciSequence
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Fibonacci Sequence Generator");

        Console.Write("Enter the number of terms: ");
        if (!int.TryParse(Console.ReadLine(), out int terms) || terms < 1)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            return;
        }

        Console.WriteLine("Fibonacci sequence:");

        int a = 0;
        int b = 1;
        for (int i = 0; i < terms; i++)
        {
            Console.Write($"{a} ");

            int temp = a;
            a = b;
            b = temp + b; 
        }

        Console.ReadKey();
    }
}
