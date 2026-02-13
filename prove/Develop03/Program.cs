using System;

class Program
{
    static void Main(string[] args)
    {

        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding; " +
                      "In all thy ways acknowledge him and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, text);

        // --- difficulty selection for my exceeding requirements---
        Console.WriteLine("Choose a difficulty level:");
        Console.WriteLine("1 - Easy (hide 2 words each round)");
        Console.WriteLine("2 - Medium (hide 4 words each round)");
        Console.WriteLine("3 - Hard (hide 6 words each round)");
        Console.Write("Enter your choice (1-3): ");

        string choice = Console.ReadLine();

        int wordsToHide = 3; // default if input is unexpected

        if (choice == "1")
        {
            wordsToHide = 2;
        }
        else if (choice == "2")
        {
            wordsToHide = 4;
        }
        else if (choice == "3")
        {
            wordsToHide = 6;
        }

        // --- main Loop ---
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");

            string input = Console.ReadLine();

            // If user types quit, end program
            if (input != null && input.Trim().ToLower() == "quit")
            {
                break;
            }

            // hide words based on chosen difficulty
            scripture.HideRandomWords(wordsToHide);

            // If all words are hidden, end program
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ending...");
                break;
            }
        }
    }
}