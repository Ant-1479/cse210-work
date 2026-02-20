using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0; // in km
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60; // kph
    }

    public override double GetPace()
    {
        return Minutes / GetDistance(); // min per km
    }

    public override string GetSummary()
    {
        string formattedDate = Date.ToString("dd MMM yyyy");
        return $"{formattedDate} Swimming ({Minutes} min) - " +
               $"Distance: {GetDistance():0.00} km, Speed: {GetSpeed():0.00} kph, Pace: {GetPace():0.00} min per km";
    }
}