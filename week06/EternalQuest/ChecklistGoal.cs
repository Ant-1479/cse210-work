using System;

public class ChecklistGoal : Goal
{
    private int _target;
    private int _completed;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _completed = 0;
        _bonus = bonus;
    }

    public override void RecordEvent(ref int totalPoints)
    {
        if (_completed < _target)
        {
            _completed++;
            int earned = Points;
            if (_completed == _target)
            {
                earned += _bonus;
                Console.WriteLine($"🏆 Checklist goal completed! You earned {earned} points including bonus { _bonus}!");
            }
            else
            {
                Console.WriteLine($"✅ Progress made! You earned {earned} points ({_completed}/{_target})");
            }
            totalPoints += earned;
        }
        else
        {
            Console.WriteLine("⚠️ This checklist goal is already completed.");
        }
    }

    public override string DisplayStatus()
    {
        string status = _completed >= _target ? "[X]" : "[ ]";
        return $"{status} {Name} ({_completed}/{_target} completed)";
    }
}