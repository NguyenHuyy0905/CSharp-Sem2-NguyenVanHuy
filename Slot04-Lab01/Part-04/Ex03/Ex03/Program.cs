using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number between 1 and 7:");

        // Input for the number
        Console.Write("Number: ");
        int userInput = int.Parse(Console.ReadLine());

        // Validate input range
        if (userInput >= 1 && userInput <= 7)
        {
            // Get the day of the week corresponding to the entered number
            string dayOfWeek = GetDayOfWeek(userInput);

            // Display the result
            Console.WriteLine($"\nThe corresponding day of the week is: {dayOfWeek}");
        }
        else
        {
            Console.WriteLine("\nInvalid input. Please enter a number between 1 and 7.");
        }

        // Wait for user to press a key before closing the console
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    // Function to get the day of the week based on the input number
    static string GetDayOfWeek(int number)
    {
        switch (number)
        {
            case 1:
                return "Monday";
            case 2:
                return "Tuesday";
            case 3:
                return "Wednesday";
            case 4:
                return "Thursday";
            case 5:
                return "Friday";
            case 6:
                return "Saturday";
            case 7:
                return "Sunday";
            default:
                return "Invalid Day";
        }
    }
}
