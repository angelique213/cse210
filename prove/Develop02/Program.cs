using System;

class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();                 // my journal object
        PromptGenerator promptGen = new PromptGenerator(); // my prompt generator object

        int choice = 0;

        // keep looping until user chooses 5
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string userInput = Console.ReadLine();
            int.TryParse(userInput, out choice); // try to convert input to number

            if (choice == 1)
            {
                // WRITE a new entry
                string prompt = promptGen.GetRandomPrompt(); // get a random prompt
                Console.WriteLine(prompt);

                Console.Write("> ");
                string response = Console.ReadLine(); // user types response

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString(); // store today's date as a string
                entry._prompt = prompt;                         // store the prompt
                entry._response = response;                     // store the response

                journal.AddEntry(entry); // add entry to journal
            }
            else if (choice == 2)
            {
                // DISPLAY entries
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                // LOAD journal from file
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                try
                {
                    journal.LoadFromFile(filename);
                    Console.WriteLine("Journal loaded!");
                }
                catch
                {
                    Console.WriteLine("Sorry, I could not load that file.");
                }
            }
            else if (choice == 4)
            {
                // SAVE journal to file
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                try
                {
                    // Exceeding requirements: confirm before overwriting an existing file
                    if (System.IO.File.Exists(filename))
                    {
                        Console.Write("That file already exists. Overwrite? (y/n): ");
                        string answer = Console.ReadLine();

                        if (answer.ToLower() != "y")
                        {
                            Console.WriteLine("Save canceled.");
                            Console.WriteLine();
                            continue;
                        }
                    }

                    journal.SaveToFile(filename);
                    Console.WriteLine("Journal saved!");
                }
                catch
                {
                    Console.WriteLine("Sorry, I could not save the file.");
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Please enter a number 1-5.");
            }

            Console.WriteLine();
        }
    }
}
