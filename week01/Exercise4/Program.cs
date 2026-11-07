using System;

class Program
{
    static void Main(string[] args)

    {   
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        

        List<int> numbers = new List<int>();

        while  (number != 0)

        {
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            number = int.Parse(userInput);
            numbers.Add(number);


            if (number != 0)
            {
                numbers.Add(number);
            }
        }
            int sum = 0;
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
                sum += num;
            }

            Console.WriteLine("The sum of the numbers is: " + sum);

            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average of the numbers is: {average:F2}");

            int largest = numbers[0];
            foreach (int num in numbers)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }
            Console.WriteLine("The largest number is: " + largest);

            int smallestPositive = int.MaxValue;

            foreach (int num in numbers)
            {
                if (num > 0 && num < smallestPositive)
                {
                    smallestPositive = num;
                }

            }

            Console.WriteLine("The smallest positive number is: " + smallestPositive);
            numbers.Sort();
            Console.WriteLine("The sorted list of numbers is: ");

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }


    }
}