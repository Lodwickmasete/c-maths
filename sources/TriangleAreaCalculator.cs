using System;

public class TriangleAreaCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Triangle Area Calculator (Heron's Formula)");

        Console.Write("Enter the length of side a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Check if the sides form a valid triangle
        if (a + b <= c || a + c <= b || b + c <= a)
        {
            Console.WriteLine("These sides do not form a valid triangle.");
            return;
        }

        double s = (a + b + c) / 2; // Semi-perimeter
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        Console.WriteLine($"Area of the triangle: {area}");
        Console.ReadKey();
    }
}
