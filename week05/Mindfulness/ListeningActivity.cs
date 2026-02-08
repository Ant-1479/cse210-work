using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List people you appreciate.",
        "List things that make you happy.",
        "List moments when you felt peace."
    };

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity helps you focus on the good things in your life."
        )
    { }

    public void Run()
    {
        StartActivity();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine(prompt);
        Console.WriteLine("Start listing items:");

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items!");
        EndActivity();
    }
}
