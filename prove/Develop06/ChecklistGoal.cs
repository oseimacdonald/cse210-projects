public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;

    public ChecklistGoal(string goalName, string category, int points, int targetCount) 
        : base(goalName, category, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
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

    public override int GetProgress() => _currentCount;
}
