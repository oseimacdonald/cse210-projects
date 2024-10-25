using System;
using System.Collections.Generic;

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
}
