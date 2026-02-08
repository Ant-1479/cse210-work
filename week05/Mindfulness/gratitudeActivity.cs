using System;

public class GratitudeActivity : Activity
{
    public GratitudeActivity()
        : base(
            "Gratitude Activity",
            "This activity helps you focus on things you are grateful for."
        )
    { }

    public void Run()
    {
        StartActivity();

        Console.WriteLine("Think quietly about things you are grateful for...");
        ShowSpinner(_duration);

        EndActivity();
    }
}
