using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        while (playAgain == "yes")
        {

        Random randomGenerator = new Random();
        int magic_no = randomGenerator.Next(1, 101);
        int guessCount = 0;

        Console.WriteLine("What is your guess?");
        int guess_no = int.Parse(Console.ReadLine());
        guessCount++;

    while (guess_no != magic_no)
        {

        if (guess_no < magic_no)
        {
            Console.WriteLine("Higher");
        }
        else if (guess_no > magic_no)
        {
            Console.WriteLine("Lower");
        }
        Console.WriteLine("What is your guess?");
        guess_no = int.Parse(Console.ReadLine());
        guessCount++; 
        }
        Console.WriteLine($"You guessed it in {guessCount} guesses!");

        Console.Write("Do you want to play again? ");
        playAgain = Console.ReadLine().ToLower();

        }

    }
}
