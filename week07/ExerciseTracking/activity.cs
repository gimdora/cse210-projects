using System;

abstract class Activity(DateTime date, int minutes)
{
    private readonly DateTime _date = date;
    private readonly int _minutes = minutes;

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        string dateText = _date.ToString("dd MMM yyyy");
        string activityName = GetType().Name;

        double distance = Math.Round(GetDistance(), 1);
        double speed = Math.Round(GetSpeed(), 1);
        double pace = Math.Round(GetPace(), 1);

        return $"{dateText} {activityName} ({_minutes} min) - " +
               $"Distance {distance} miles, Speed {speed} mph, " +
               $"Pace {pace} min per mile";
    }
}
