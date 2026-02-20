using System;

public class Running : Activity
{
    private double _distanceKm; // distance in km

    public Running(DateTime date, int minutes, double distanceKm)
        : base(date, minutes)
    {
        _distanceKm = distanceKm;
    }

    public override double GetDistance()
    {
        return _distanceKm;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60; // km per hour
    }

    public override double GetPace()
    {
        return Minutes / GetDistance(); // min per km
    }

    public override string GetSummary()
    {
        string formattedDate = Date.ToString("dd MMM yyyy");
        return $"{formattedDate} Running ({Minutes} min) - " +
               $"Distance: {GetDistance():0.00} km, Speed: {GetSpeed():0.00} kph, Pace: {GetPace():0.00} min per km";
    }
}