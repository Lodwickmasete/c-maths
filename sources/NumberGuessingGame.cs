using System;

public class NumberGuessingGame
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Number Guessing Game!");

        Random random = new Random();
        int secretNumber = random.Next(1, 101); // Generate a number between 1 and 100
        int guessCount = 0;

        Console.WriteLine("I've chosen a number between 1 and 100. Can you guess it?");

        while (true)
        {
            Console.Write("Enter your guess: ");
            if (!int.TryParse(Console.ReadLine(), out int guess))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            guessCount++;

            if (guess < secretNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You guessed it in {guessCount} tries.");
                break;
            }
        }

        Console.ReadKey();
    }
}
