// MathAssignment inherits from Assignment
public class MathAssignment : Assignment
{
    // Stores the section number
    private string _section;

    // Stores the problem numbers
    private string _problems;

    // Constructor sets all values and calls base constructor
    public MathAssignment(string studentName, string topic, string section, string problems)
        : base(studentName, topic) // Sends name and topic to Assignment
    {
        _section = section;
        _problems = problems;
    }

    // Returns the homework details
    public string GetHomeworkList()
    {
        return $"Section {_section} Problems {_problems}";
    }
}