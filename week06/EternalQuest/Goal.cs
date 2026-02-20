using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public string Name { get { return _name; } }
    public string Description { get { return _description; } }
    public int Points { get { return _points; } }

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent(ref int totalPoints); // Polymorphism
    public abstract string DisplayStatus(); // Polymorphism
}