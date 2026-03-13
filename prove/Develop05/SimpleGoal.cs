using System;

// A goal that can be completed once
public class SimpleGoal : Goal
{
    // Tracks completion status
    private bool _isComplete;

    // Constructor for a simple goal
    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    // Record the goal and give points only once
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }

        return 0;
    }

    // Returns whether the goal is finished
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Display goal in list
    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description})";
    }

    // Save goal as text
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_name}|{_description}|{_points}|{_isComplete}";
    }
}