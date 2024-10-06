using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Journal
{
    public List<Entry> Entries { get; set; } = new List<Entry>();
    public List<string> Prompts { get; set; } = new List<string>
    {
        "who was the most interesting person i interacted with today?",
        "what was the best part of my day?",
        "how did i see the Hand of the Lord in life today?",
        "what was the strongest emotion i felt today?",
        "if i had one thing i could do over today, what would it be?"
    };

    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in Entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in Entries)
            {
                var tags = string.Join(",", entry.Tags);
                writer.WriteLine($"{entry .Date} | {entry .Prompt} | {entry .Response} | {entry .Mood} | {tags}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        Entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                var entry = new Entry
                {
                    Date = parts[0],
                    Prompt = parts[1],
                    Response = parts[2],
                    Mood = parts[3],
                    Tags = parts.Length > 4 ? parts[4].Split(',').ToList() : new List<string>()
                };
                Entries.Add(entry);   
            }
        }
    }

    public void SearchEntries(string keyword)
    {
        var results = Entries.Where(e => e.Response.Contains(keyword) || e.Tags.Contains(keyword)).ToList();
        if (results.Any())
        {
            foreach(var entry in results)
            {
                entry.Display();
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("No entries found.");
        }
    }

    public void AddPrompt(string prompt)
    {
        Prompts.Add(prompt);
    }
}