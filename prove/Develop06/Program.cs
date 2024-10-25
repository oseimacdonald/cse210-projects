using System;

public class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        
        // Sample Goals
        goalManager.AddGoal(new SimpleGoal("Run a marathon", "Fitness", 1000));
        goalManager.AddGoal(new ChecklistGoal("Read scriptures", "Spiritual", 100, 10));
        goalManager.AddGoal(new EternalGoal("Meditate", "Mental Health", 50));

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Display Goals");
            Console.WriteLine("2. Record an Event");
            Console.WriteLine("3. Show Total Points");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    goalManager.DisplayGoals();
                    break;
                case "2":
                    Console.Write("Enter the goal name to record an event: ");
                    string goalName = Console.ReadLine();
                    goalManager.RecordEvent(goalName);
                    break;
                case "3":
                    Console.WriteLine($"Total Points: {goalManager.GetTotalPoints()}");
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}
