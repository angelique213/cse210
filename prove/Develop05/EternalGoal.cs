using System;

// A goal that never finishes
public class EternalGoal : Goal
{
    // Constructor for eternal goal
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    // Always give points when recorded
    public override int RecordEvent()
    {
        return _points;
    }

    // Eternal goals are never complete
    public override bool IsComplete()
    {
        return false;
    }

    // Display eternal goal in list
    public override string GetDetailsString()
    {
        return $"[ ] {_name} ({_description})";
    }

    // Save goal as text
    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_name}|{_description}|{_points}";
    }
}