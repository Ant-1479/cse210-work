using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public DateTime Date { get { return _date; } }
    public int Minutes { get { return _minutes; } }

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Abstract methods to override in derived classes
    public abstract double GetDistance(); // in km or miles
    public abstract double GetSpeed();    // in kph or mph
    public abstract double GetPace();     // minutes per km or mile

    // Summary method
    public virtual string GetSummary()
    {
        string formattedDate = _date.ToString("dd MMM yyyy");
        string activityType = this.GetType().Name;
        return $"{formattedDate} {activityType} ({_minutes} min) - " +
               $"Distance: {GetDistance():0.00} km, Speed: {GetSpeed():0.00} kph, Pace: {GetPace():0.00} min per km";
    }
}