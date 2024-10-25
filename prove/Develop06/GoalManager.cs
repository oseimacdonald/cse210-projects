using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

// Goal manager class
public class GoalManager
{
    private List<Goal> _goals;

    public GoalManager()
    {
        _goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal.GetGoalName().Equals(goalName, StringComparison.OrdinalIgnoreCase))
            {
                goal.RecordEvent();
                Console.WriteLine($"Recorded event for: {goalName}");
                return;
            }
        }
        Console.WriteLine($"Goal not found: {goalName}");
    }

    public void DisplayGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public int GetTotalPoints()
    {
        int totalPoints = 0;
        foreach (var goal in _goals)
        {
            totalPoints += goal.GetProgress() * goal.GetPoints();
        }
        return totalPoints;
    }

    public void SaveGoals(string filename)
    {
        string json = JsonConvert.SerializeObject(_goals, Formatting.Indented);
        File.WriteAllText(filename, json);
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            string json = File.ReadAllText(filename);
            _goals = JsonConvert.DeserializeObject<List<Goal>>(json);
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
