using System;

class Program
{

    static void Main(string[] args)
    {
        // Test the first constructor
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // Test the second constructor
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // Test the third constructor
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // Test another fraction
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Test getters
        Console.WriteLine("Numerator: " + f3.GetTop());
        Console.WriteLine("Denominator: " + f3.GetBottom());

        // Test setters
        f3.SetTop(7);
        f3.SetBottom(9);

        Console.WriteLine("After changing the fraction:");
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
    }
}