using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you overcame a challenge.",
        "Recall a moment when you helped someone.",
        "Think of a time you did something truly difficult."
    };

    public ReflectionActivity()
        : base(
            "Reflection Activity",
            "This activity helps you reflect on moments of strength and resilience."
        )
    { }

    public void Run()
    {
        StartActivity();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine(prompt);
        Console.WriteLine();
        Console.WriteLine("Think about this...");
        ShowSpinner(_duration);

        EndActivity();
    }
}
