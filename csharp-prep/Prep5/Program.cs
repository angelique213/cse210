using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Hello Prep5 World!");?*/

        DisplayWelcome();

        string name = PromptUserName();
        int favNumber = PromptUserNumber();

        PromptUserBirthYear(out int birthYear);

        int squared = SquareNumber(favNumber);

        DisplayResult(name, squared, birthYear);
        
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }
    
    static int SquareNumber(int number)
    {
        return number * number;
    }
    
    static void DisplayResult (string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");

        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
}
