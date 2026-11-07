using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your First Name? ");
        string firstname = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();
        Console.WriteLine($"My name is {lastname}, {firstname} {lastname} ");
    }
}