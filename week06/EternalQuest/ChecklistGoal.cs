using System;

class ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0) : Goal(name, description, points)
{
    private int _amountCompleted = amountCompleted;
    private readonly int _target = target;
    private readonly int _bonus = bonus;

    public override int RecordEvent()
    {
        _amountCompleted += 1;

        int totalPoints = GetPoints();

        if (_amountCompleted == _target)
        {
            totalPoints += _bonus;
        }

        return totalPoints;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_target}|{_amountCompleted}";
    }
}
