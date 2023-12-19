using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Factorials of integers from 1 to 20:");

        for (int i = 1; i <= 20; i++)
        {
            ulong factorial = CalculateFactorial(i);
            Console.WriteLine($"Factorial of {i}: {factorial}");
        }

        // Wait for user to press a key before closing the console
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    // Function to calculate the factorial of a number
    static ulong CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }

        ulong result = 1;

        for (int i = 2; i <= n; i++)
        {
            result *= (ulong)i;
        }

        return result;
    }
}
