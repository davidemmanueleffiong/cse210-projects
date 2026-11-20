using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        while (playAgain)
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);


            Console.WriteLine("Welcome to the Magic Number Game!");
            Console.WriteLine("I have selected a magic number between 1 and 100.");
            Console.WriteLine("Try to guess the magic number!");
        
            int guess = -1;
            int guessCount = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                guess = int.Parse(input);

                guessCount++;   

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else
                {
                    Console.WriteLine("Congratulations! You guessed the magic number!");
                }

            }

            Console.WriteLine($"It took you {guessCount} guesses. ");

            Console.Write("Do you want to play again (yes/no) ");
            string answer = Console.ReadLine().ToLower();

            if (answer != "yes")
            {
                playAgain = false;
            }
        }

        Console.WriteLine("Thanks for playing!");

    }

}