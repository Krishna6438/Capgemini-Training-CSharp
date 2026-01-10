using System;

public class EventExample
{
    public delegate void Notify();
    public static event Notify? Reached500;

    public static void Run()
    {
        // Subscribe to event
        Reached500 += ValueReached500Plus;

        while (true)
        {
            Console.WriteLine("Enter a number (or type 'exit' to quit): ");
            string? input = Console.ReadLine();

            if (input?.ToLower() == "exit")
                break;

            if (int.TryParse(input, out int num))
            {
                if (num > 500)
                {
                    // Safe event invocation
                    Reached500?.Invoke();
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    private static void ValueReached500Plus()
    {
        Console.WriteLine("✅ Yes! Value has reached 500 or above.");
    }
}
