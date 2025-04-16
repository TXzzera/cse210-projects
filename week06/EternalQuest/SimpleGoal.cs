using System;

public class SimpleGoal : Goal
{
    private bool _completed;
    private string _dueDate;

    public SimpleGoal(string title, string description, string dueDate, string difficulty)
        : base(title, description, DeterminePoints(difficulty))
    {
        _dueDate = dueDate;
        _completed = false;
    }

    private static double DeterminePoints(string difficulty)
    {
        return difficulty.ToLower() switch
        {
            "easy" => 100,
            "medium" => 300,
            "hard" => 500,
            _ => 100
        };
    }

    public override void IsCompleted()
    {
        _completed = true;
    }

    public override string Display()
    {
        string status = _completed ? "[X]" : "[ ]";
        return $"{status} {GetTitle()} - {GetDescription()} (Due: {_dueDate})";
    }

    public override double GetPoints()
    {
        return _completed ? base.GetPoints() : 0;
    }
}