using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the following information:");

        // Input for name
        Console.Write("Name: ");
        string name = Console.ReadLine();

        // Input for address
        Console.Write("Address: ");
        string address = Console.ReadLine();

        // Input for phone
        Console.Write("Phone: ");
        string phone = Console.ReadLine();

        // Display entered information
        Console.WriteLine("\nDisplaying Information:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Address: {address}");
        Console.WriteLine($"Phone: {phone}");

        // Wait for user to press a key before closing the console
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
