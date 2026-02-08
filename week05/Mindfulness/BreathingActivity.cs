using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by guiding you through slow breathing."
        )
    { }

    public void Run()
    {
        StartActivity();

        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();

            Console.Write("Breathe out...");
            ShowCountDown(6);
            Console.WriteLine();

            elapsed += 10;
        }

        EndActivity();
    }
}
