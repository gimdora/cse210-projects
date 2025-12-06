using System;

class Swimming(DateTime date, int minutes, int laps) : Activity(date, minutes)
{
    private readonly int _laps = laps;

    public override double GetDistance()
    {
        double distanceKm = _laps * 50.0 / 1000.0;
        double distanceMiles = distanceKm * 0.62;
        return distanceMiles;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / GetMinutes()) * 60.0;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return GetMinutes() / distance;
    }
}
