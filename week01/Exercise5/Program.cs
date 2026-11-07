using System;

class Program
{
    static void Main(string[] args)

    {   static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }
        DisplayMessage();

        static void PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
        PromptUserName();

        static void SquareNumber()
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int square = number * number;
            Console.WriteLine($"The square of {number} is {square}.");
        }
        SquareNumber();

        static void DisplayResult()
        {
            Console.WriteLine("Thank you for using the program. Goodbye!");
        }
        DisplayResult();
    }

}
        
    

