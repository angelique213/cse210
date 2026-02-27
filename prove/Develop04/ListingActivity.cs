using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    // Stores prompts for the listing activity
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    // Constructor sets name and description using base class
    public ListingActivity()
        : base("Listing Activity",
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    // Returns a random prompt from the list
    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    // Runs the listing activity
    public void Run()
    {
        DisplayStartMessage(); // show start message and get duration

        string prompt = GetRandomPrompt(); // get random prompt

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();

        Console.Write("You may begin in: ");
        ShowCountdown(5); // short countdown before starting
        Console.WriteLine();

        

        int count = 0; // counts user entries

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        // keep accepting input until time ends
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {count} items!");

        DisplayEndingMessage(); // show ending message
    }
}