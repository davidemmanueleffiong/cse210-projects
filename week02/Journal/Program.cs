using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                {
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine() ?? "";

                    Entry entry = new Entry();
                    entry._date = DateTime.Now.ToShortDateString();
                    entry._promptText = prompt;
                    entry._entryText = response;
                    journal.AddEntry(entry);
                    break;
                }

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                {
                    Console.Write("Filename to save to: ");
                    string saveFile = Console.ReadLine() ?? "";
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved.");
                    break;
                }

                case "4":
                {
                    Console.Write("Filename to load: ");
                    string loadFile = Console.ReadLine() ?? "";
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded.");
                    break;
                }

                case "5":
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Please choose a number from 1 to 5.");
                    break;
            }

            Console.WriteLine();
        }
    }
}