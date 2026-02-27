using System;

public class BreathingActivity : Activity
{
    // Constructor sends name and description to base class
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    // Runs the breathing activity
    public void Run()
    {
        // Display starting message and get duration
        DisplayStartMessage();

        // Determine when the activity should stop
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        // Continue breathing cycles until time expires
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountdown(4); // inhale countdown

            Console.WriteLine();
            Console.Write("Breathe out... ");
            ShowCountdown(4); // exhale countdown

            Console.WriteLine();
        }

        // Display ending message
        DisplayEndingMessage();
    }
}