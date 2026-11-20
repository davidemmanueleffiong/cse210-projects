
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        if (numbers.Count > 0)
        {
            // Calculate the sum
            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine("The sum is: " + sum);

            // Calculate the average
            double average = (double)sum / numbers.Count;

            Console.WriteLine("The average is: " + average);

            // Find the largest number
            int largest = numbers[0];

            foreach (int num in numbers)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }

            Console.WriteLine("The largest number is: " + largest);

            // Find the smallest positive number
            int smallestPositive = int.MaxValue;
            bool foundPositive = false;

            foreach (int num in numbers)
            {
                if (num > 0 && num < smallestPositive)
                {
                    smallestPositive = num;
                    foundPositive = true;
                }
            }

            if (foundPositive)
            {
                Console.WriteLine("The smallest positive number is: " + smallestPositive);
            }
            else
            {
                Console.WriteLine("No positive number was entered.");
            }

            // Sort the list
            numbers.Sort();

            Console.WriteLine("The sorted list is:");

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
