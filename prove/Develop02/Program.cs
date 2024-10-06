using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Journal journal = new Journal();
        string[] prompts = {
            "who was the most interesting person i interacted with today?",
            "what was the best part of my day?",
            "how did i see the Hand of the Lord in life today?",
            "what was the strongest emotion i felt today?",
            "if i had one thing i could do over today, what would it be?"
        };

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Search entries");
            Console.WriteLine("6. Add custom prompt");
            Console.WriteLine("7. Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                
                case "1":
                    Random rand = new Random();
                //  string prompt = prompts[rand.Next(prompts.Length)];
                    string prompt = journal.Prompts[new Random().Next(journal.Prompts.Count)];
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    Console.Write("How did you feel today? ");
                    string mood = Console.ReadLine();
                    Console.Write("Enter tags (comma seperated): ");
                    var tags = Console.ReadLine().Split(',').Select(t => t.Trim()).ToList();
                    journal.AddEntry(new Entry { Date = DateTime.Now.ToString("yyyy-mm-dd"), Prompt = prompt, Response = response, Mood = mood, Tags = tags });
                    break;
                case "2":
                    journal.DisplayEntries();
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
                    Console.Write("Enter a keyword to search: ");
                    string keyword = Console.ReadLine();
                    journal.SearchEntries(keyword);
                    break;
                case "6":
                    Console.Write("Enter a custom prompt: ");
                    string customPrompt = Console.ReadLine();
                    journal.AddPrompt(customPrompt);
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}