using System;

class Program
{
    // Exceeding requirements: tracks how many activities are completed during the session
    static int _totalActivities = 0;

    static void Main(string[] args)
    {
        string choice = "";

        // Keep showing the menu until user selects Quit
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Breathing Activity");
            Console.WriteLine(" 2. Reflection Activity");
            Console.WriteLine(" 3. Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                _totalActivities++; // Increase count after completion
            }
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
                _totalActivities++; // Increase count after completion
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                _totalActivities++; // Increase count after completion
            }
        }

        // When user quits, display total completed activities
        Console.WriteLine();
        Console.WriteLine($"You completed {_totalActivities} activities during this session.");
        Console.WriteLine("Thank you for using the Mindfulness Program!");
    }
}