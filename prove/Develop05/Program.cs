using System;

// Main program that runs the Eternal Quest system
class Program
{
    static void Main(string[] args)
    {
        // create the goal manager object
        GoalManager manager = new GoalManager();

        // Variable to store the user's menu choice
        string choice = "";

        // keep running the program until the user chooses to quit
        while (choice != "6")
        {
            Console.WriteLine();

            // Display menu options
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            //ask the user for a menu choice
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            Console.WriteLine();

            // display the user's current score and level
            manager.DisplayPlayerInfo();
            Console.WriteLine();

            // Handle the user's menu choice
            if (choice == "1")
            {
                // Create a new goal
                manager.CreateGoal();
            }
            else if (choice == "2")
            {
                // display all goals
                manager.ListGoalDetails();
            }
            else if (choice == "3")
            {
                // Save goals and score to a file
                manager.SaveGoals();
            }
            else if (choice == "4")
            {
                // load goals and score from a file
                manager.LoadGoals();
            }
            else if (choice == "5")
            {
                // record progress on a goal and award points
                manager.RecordEvent();
            }
        }
    }
}