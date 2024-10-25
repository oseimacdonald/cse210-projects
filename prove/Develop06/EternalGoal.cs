using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

// Eternal goal class
public class EternalGoal : Goal
{
    private int _recordedCount;

    public EternalGoal(string goalName, string category, int points) 
        : base(goalName, category, points)
    {
        _recordedCount = 0; // Initialize recorded count to zero
    }

    public override void RecordEvent()
    {
        _recordedCount++; // Increment the count for each recorded event
    }

    public override string GetDetailsString() =>
        $"{GetGoalName()} - Category: {GetCategory()}, Points: {GetPoints()}, Recorded: {_recordedCount} times";

    public override int GetProgress() => _recordedCount; // Progress reflects recorded events
}
