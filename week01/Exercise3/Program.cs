using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        while (playAgain)
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guessCount = 0;

            Console.WriteLine("Welcome to the Magic Number Game!");
            Console.WriteLine("I have selected a magic number between 1 and 100.");
            Console.WriteLine("Try to guess the magic number!");
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            int guess = int.Parse(userInput);

            guessCount++;

            while (guess != magicNumber);
            {
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                else
                {
                    Console.WriteLine("Lower");
                }

                Console.Write("What is your guess");
                guess = int.Parse(Console.ReadLine());

                guessCount++;
            }

            Console.WriteLine("You guessed it! ");
            Console.WriteLine($"It took you {guessCount} gueses. ");

            Console.Write("Do you want to play again (yes/no) ");
            string answer = Console.ReadLine().ToLower();

            if (answer != "yes");
            {
                playAgain = false;
            }
        }

        Console.WriteLine("Thanks for playing");

    }

}