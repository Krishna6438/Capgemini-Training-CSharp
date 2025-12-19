using System;

class Day02
{
    // Method to check whether a number is even
    public bool IsEven(int n)
    {
        // If remainder when divided by 2 is 0, number is even
        if (n % 2 == 0)
        {
            return true;
        }

        // Otherwise, number is odd
        return false;
    }

    // Method to check height
    public string Height(int h)
    {
        if (h < 150) // Dwarf
        {
            return "Dwarf";
        }
        if (h > 150 && h < 165) // Average
        {
            return "Average";
        }
        if (h > 165 && h < 190) // Tall
        {
            return "Tall";
        }
        else
        {
            return "Abnormal";
        }
    }


    // Entry method to run the program logic
    public static void Run()
    {
        // Create an object of Day02 class
        Day02 d = new Day02();

        // Loop runs continuously until user types "quit"
        while (true)
        {
            // Ask user for input
            Console.Write("Enter a number (or type 'quit' to exit): ");

            // Read input from the console (can be null)
            string? input = Console.ReadLine();

            // Check if user wants to exit the program
            // string.Equals is null-safe and ignores case (QUIT, quit, Quit, etc.)
            if (string.Equals(input, "quit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Thanks for using this...... ");
                break; // Exit the loop
            }

            // Try to convert input string to integer
            if (int.TryParse(input, out int number))
            {
                // If conversion is successful, check if the number is even
                Console.WriteLine($"Is {number} even: {d.IsEven(number)}");
            }
            else
            {
                // If input is neither a number nor 'quit'
                Console.WriteLine("Invalid Number......");
            }


        }

        // Height check
        Console.WriteLine("Enter height in cm only");
        string? height = Console.ReadLine(); // Read height input
        if (int.TryParse(height, out int n))// Convert height to integer
        {
            Console.WriteLine($"According to given height: {d.Height(160)}");
        }
    }
}
