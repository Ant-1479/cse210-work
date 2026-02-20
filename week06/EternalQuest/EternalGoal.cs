using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent(ref int totalPoints)
    {
        totalPoints += Points;
        Console.WriteLine($"🎯 Goal recorded! You earned {Points} points.");
    }

    public override string DisplayStatus()
    {
        return $"[∞] {Name}";
    }
}