public abstract class Goal
{
    private string _goalName;
    private string _category;
    private int _points;

    protected Goal(string goalName, string category, int points)
    {
        _goalName = goalName;
        _category = category;
        _points = points;
    }

    public string GetGoalName() => _goalName;
    public string GetCategory() => _category;
    public int GetPoints() => _points;

    public abstract void RecordEvent();
    public abstract string GetDetailsString();
    public abstract int GetProgress();
}
