using System;

class Cycling(DateTime date, int minutes, double speed) : Activity(date, minutes)
{
    private readonly double _speed = speed;

    public override double GetDistance()
    {
        return _speed * GetMinutes() / 60.0;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60.0 / _speed;
    }
}
