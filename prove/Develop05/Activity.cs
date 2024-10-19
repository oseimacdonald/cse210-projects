using System;
using System.Threading;

public abstract class Activity
{
    protected int duration;

    public void RunActivity()
    {
        Console.Clear();
        Console.WriteLine(GetStartingMessage());
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Pause(3); // Prepare time
        PerformActivity();
        FinishActivity();
    }

    protected abstract string GetStartingMessage();
    protected abstract void PerformActivity();

    protected void FinishActivity()
    {
        Console.WriteLine("Good job! You have completed the activity.");
        Console.WriteLine($"You spent {duration} seconds on this activity.");
        Pause(3); // Ending pause
    }

    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
