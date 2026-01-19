using System;                    
using System.Collections.Generic; // I need this to use List<Job>

public class Resume
{
    public string _name = "";           // I store the person’s name here
    public List<Job> _jobs = new List<Job>(); // I store all jobs in a list here

    public void Display() // I display the whole resume (name first, then jobs)
    {
        Console.WriteLine($"Name: {_name}"); // I print name
        Console.WriteLine("Jobs:");          // I print a label before listing jobs

        // I loop through each Job in list and tell it to display itself
        foreach (Job job in _jobs)
        {
            job.Display(); // each job knows how to print its own details
        }
    }
}
