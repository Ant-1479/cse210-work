using System;

public class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isCompleted = false;
    }

    public override void RecordEvent(ref int totalPoints)
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            totalPoints += Points;
            Console.WriteLine($"✅ Goal completed! You earned {Points} points.");
        }
        else
        {
            Console.WriteLine("⚠️ This goal is already completed.");
        }
    }

    public override string DisplayStatus()
    {
        return _isCompleted ? $"[X] {Name}" : $"[ ] {Name}";
    }
}