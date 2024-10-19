public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Getter for student name
    public string GetStudentName()
    {
        return _studentName;
    }

    // Method to get a summary of the Assignment
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}