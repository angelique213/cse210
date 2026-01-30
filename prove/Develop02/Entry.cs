using System;

public class Entry
{
    public string _date = "";         // I store the date here
    public string _prompt = "";   // I store the prompt here
    public string _response = ""; // I store my response here


    public void Display() // I show one entry on the screen
    {
        Console.WriteLine($"Date: {_date}");         // I print the date
        Console.WriteLine($"Prompt: {_prompt}"); // I print the prompt
        Console.WriteLine($"{_response}");       // I print my response
        Console.WriteLine();                         // blank line just for spacing
    }

    public string ToFileString() // I turn my entry into ONE line for saving
    {
        return $"{_date}|{_prompt}|{_response}"; // I use | as separator
    }
}
