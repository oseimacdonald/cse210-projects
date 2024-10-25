public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string goalName, string category, int points) 
        : base(goalName, category, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true; // Mark as complete
    }

    public override string GetDetailsString() =>
        $"{GetGoalName()} - Category: {GetCategory()}, Points: {GetPoints()}, Completed: {(_isComplete ? "X" : " ")}";

    public override int GetProgress() => _isComplete ? 1 : 0;
}
