using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    string prompt = GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("Response: ");
                    string response = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(response))
                    {
                        Entry newEntry = new Entry(prompt, response);
                        journal.AddEntry(newEntry);
                    }
                    else
                    {
                        Console.WriteLine("Entry cannot be empty.");
                    }
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static string GetRandomPrompt()
    {
        string[] prompts =
        {
            "What was the best part of your day?",
            "Who did you help today?",
            "What did you learn today?",
            "What are you grateful for today?",
            "What challenged you today?"
        };

        Random rand = new Random();
        return prompts[rand.Next(prompts.Length)];
    }
}