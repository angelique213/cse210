// WritingAssignment inherits from Assignment
public class WritingAssignment : Assignment
{
    // Stores the title of the writing assignment
    private string _title;

    // Constructor sets values and calls base constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic) // Sends name and topic to Assignment
    {
        _title = title;
    }

    // Returns the title and student name
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}