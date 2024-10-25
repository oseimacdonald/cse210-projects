using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

// Main program
public class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Display Goals");
            Console.WriteLine("2. Record an Event");
            Console.WriteLine("3. Show Total Points");
            Console.WriteLine("4. Create a New Goal");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
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
                    CreateNewGoal(goalManager);
                    break;
                case "5":
                    Console.Write("Enter filename to save goals: ");
                    string saveFile = Console.ReadLine();
                    goalManager.SaveGoals(saveFile);
                    break;
                case "6":
                    Console.Write("Enter filename to load goals: ");
                    string loadFile = Console.ReadLine();
                    goalManager.LoadGoals(loadFile);
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    private static void CreateNewGoal(GoalManager goalManager)
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.WriteLine("3. Eternal Goal");
        Console.Write("Select an option: ");

        string goalType = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string goalName = Console.ReadLine();
        Console.Write("Enter category: ");
        string category = Console.ReadLine();
        Console.Write("Enter points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                goalManager.AddGoal(new SimpleGoal(goalName, category, points));
                break;
            case "2":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completion: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goalManager.AddGoal(new ChecklistGoal(goalName, category, points, targetCount, bonusPoints));
                break;
            case "3":
                goalManager.AddGoal(new EternalGoal(goalName, category, points));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
        Console.WriteLine($"New goal '{goalName}' added successfully!");
    }
}
