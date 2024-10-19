using System;

public static class Utilities
{
    public static int GetValidDuration()
    {
        int duration;
        while (true)
        {
            Console.Write("Enter the duration in seconds: ");
            if (int.TryParse(Console.ReadLine(), out duration) && duration > 0)
            {
                return duration;
            }
            Console.WriteLine("Please enter a valid positive number.");
        }
    }

    public static void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
