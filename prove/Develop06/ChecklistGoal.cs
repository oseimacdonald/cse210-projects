using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

// Checklist goal class
public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints; // Bonus points when goal is completed

    public ChecklistGoal(string goalName, string category, int points, int targetCount, int bonusPoints) 
        : base(goalName, category, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints; // Initialize bonus points
    }

    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
        }
    }

    public override string GetDetailsString() =>
        $"{GetGoalName()} - Category: {GetCategory()}, Points: {GetPoints()}, Completed: {_currentCount}/{_targetCount}";

    public override int GetProgress() => _currentCount + (_currentCount >= _targetCount ? _bonusPoints : 0);
}
