public class Assignment
{
    // Stores the student's name
    private string _studentName;

    // Stores the assignment topic
    private string _topic;

    // Constructor sets the name and topic when object is created
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Returns a summary with student name and topic
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Returns the student's name
    public string GetStudentName()
    {
        return _studentName;
    }
}