using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    protected override string GetStartingMessage()
    {
        return "Listing Activity\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        string prompt = Prompts.ListingPrompts[random.Next(Prompts.ListingPrompts.Count)];
        Console.WriteLine(prompt);
        Utilities.Pause(3); // Time to think about the prompt

        Console.WriteLine("Start listing your items (press Enter after each):");
        List<string> items = new List<string>();
        int timeSpent = 0;

        while (timeSpent < duration)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
            timeSpent += 2; // Assume each entry takes 2 seconds
        }

        Console.WriteLine($"You listed {items.Count} items.");
    }
}

