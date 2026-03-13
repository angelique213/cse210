using System;

// Base class for all goal types
public abstract class Goal
{
    // Common fields shared by all goals
    protected string _name;
    protected string _description;
    protected int _points;

    // Constructor to initialize goal data
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Record progress on a goal and return points earned
    public abstract int RecordEvent();

    // Check if the goal is completed
    public abstract bool IsComplete();

    // Display goal details in the goal list
    public abstract string GetDetailsString();

    // Convert goal into text for saving to file
    public abstract string GetStringRepresentation();
}