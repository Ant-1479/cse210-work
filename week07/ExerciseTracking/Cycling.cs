using System;

public class Cycling : Activity
{
    private double _speedKph; // average speed (if given) OR could calculate from distance

    public double DistanceKm { get; private set; }

    public Cycling(DateTime date, int minutes, double distanceKm)
        : base(date, minutes)
    {
        DistanceKm = distanceKm;
    }

    public override double GetDistance()
    {
        return DistanceKm;
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
        return $"{formattedDate} Cycling ({Minutes} min) - " +
               $"Distance: {GetDistance():0.00} km, Speed: {GetSpeed():0.00} kph, Pace: {GetPace():0.00} min per km";
    }
}