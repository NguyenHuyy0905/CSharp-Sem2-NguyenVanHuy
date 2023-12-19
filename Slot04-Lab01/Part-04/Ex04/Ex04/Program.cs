using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nThe first 9 multiples of {n} are:");

        for (int i = 1; i <= 9; i++)
        {
            int multiple = n * i;
            Console.WriteLine($"{n} x {i} = {multiple}");
        }

        // Wait for user to press a key before closing the console
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
