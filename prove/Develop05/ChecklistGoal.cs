using System;

// A goal that must be done multiple times
public class ChecklistGoal : Goal
{
    // Number of times needed
    private int _targetCount;

    // Number of times completed so far
    private int _currentCount;

    // Bonus points when finished
    private int _bonus;

    // Constructor for checklist goal
    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, int currentCount = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = currentCount;
    }

    // Record progress and give bonus if finished
    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;

            if (_currentCount == _targetCount)
            {
                return _points + _bonus;
            }

            return _points;
        }

        return 0;
    }

    // Check if the goal is complete
    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    // Display checklist goal in list
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description}) -- Completed {_currentCount}/{_targetCount} times";
    }

    // Save goal as text
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_bonus}|{_targetCount}|{_currentCount}";
    }
}