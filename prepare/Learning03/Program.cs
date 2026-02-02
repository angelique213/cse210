using System;

class Program
{
    static void Main(string[] args)
    {
        // creates a fraction using the default constructor (1/1)
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // creates a fraction with a whole number (5/1)
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // creates a fraction with top and bottom (3/4)
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // creates another fraction (1/3)
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // random number generator
        Random random = new Random();

        // fraction object reused inside the loop
        Fraction f5 = new Fraction();

        // loop to generate and display 20 random fractions
        for (int i = 0; i < 20; i++)
        {
            // generates random top and bottom values
            int topValue = random.Next(1, 11);
            int bottomValue = random.Next(1, 11);

            // updates the fraction values
            f5.SetTop(topValue);
            f5.SetBottom(bottomValue);

            // displays the fraction and its decimal value
            Console.Write($"Fraction {i + 1}: ");
            Console.Write($"string: {f5.GetFractionString()}");
            Console.WriteLine($" Number: {f5.GetDecimalValue()}");
        }
    }
}
