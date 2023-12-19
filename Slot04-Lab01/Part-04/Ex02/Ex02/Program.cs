using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter three integer numbers:");

        // Input for the first number
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        // Input for the second number
        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        // Input for the third number
        Console.Write("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());

        // Find the maximum number
        int maxNumber = FindMax(num1, num2, num3);

        // Display the maximum number
        Console.WriteLine($"\nThe maximum number is: {maxNumber}");

        // Wait for user to press a key before closing the console
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    // Function to find the maximum among three numbers
    static int FindMax(int a, int b, int c)
    {
        int max = a;

        if (b > max)
        {
            max = b;
        }

        if (c > max)
        {
            max = c;
        }

        return max;
    }
}
