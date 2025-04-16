using System;

public class EternalGoal : Goal
{
    private int _timesCompleted;

    public EternalGoal(string title, string description)
        : base(title, description, 100)
    {
        _timesCompleted = 0;
    }

    public override void IsCompleted()
    {
        _timesCompleted++;
    }

    public override string Display()
    {
        return $"[∞] {GetTitle()} - {GetDescription()} (Finished {_timesCompleted} times.)";
    }

    public override double GetPoints()
    {
        return base.GetPoints() * _timesCompleted;
    }
}
