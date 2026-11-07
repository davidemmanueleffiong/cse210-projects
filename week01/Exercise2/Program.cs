using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
           Console.WriteLine("Remark: Amazing!");
        }
        else if (grade >=80)
        {
            letter = "B";
            Console.WriteLine("Remark: Excellent!");
        }
        else if (grade >=70)
        {
            letter = "C";
            Console.WriteLine("Remark: Good!");
        }
        else if (grade >=60)
        {
            letter = "D";
            Console.WriteLine("Remark: You tried, but try harder next time!");
        }
        else if (grade <60)
        {
            letter = "F";
            Console.WriteLine("Remark: You failed, please put more effort next term!"); 
        }

        else
        {
            Console.WriteLine("No such Score Found!");
        }

        if (grade >=90)
        {
            Console.WriteLine("Congratulations you have nailed it by having a score above 90");
        }
        else if (grade <60)
        {
            Console.WriteLine("Better Luck next time. ");
        }
       

        string sign = "";
        int lastDigit = grade % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit <= 3)
        {
            sign = "-";
        }
        if (letter == "A" && lastDigit >= 7)
        {
            sign = "";
        }
        if (letter == "F")
        {
            sign = "";
        }
      
      
        Console.WriteLine($"Your grade is: {letter}{sign}");

    }
    

}