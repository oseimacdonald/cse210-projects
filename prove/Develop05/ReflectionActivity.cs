using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    protected override string GetStartingMessage()
    {
        return "Reflection Activity\nThis activity will help you reflect on times in your life when you have shown strength and resilience.";
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        string prompt = Prompts.ReflectionPrompts[random.Next(Prompts.ReflectionPrompts.Count)];
        Console.WriteLine(prompt);
        Utilities.Pause(5); // Pause to think about the prompt

        int timeSpent = 0;
        while (timeSpent < duration)
        {
            string question = Prompts.ReflectionQuestions[random.Next(Prompts.ReflectionQuestions.Count)];
            Console.WriteLine(question);
            Utilities.Pause(5); // Pause after each question
            timeSpent += 5; // Increment time spent
        }
    }
}
