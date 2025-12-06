using System;

class Running(DateTime date, int minutes, double distance) : Activity(date, minutes)
{
    private readonly double _distance = distance;

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60.0;
    }

    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }
}
