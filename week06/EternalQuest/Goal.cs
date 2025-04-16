using System;
using System.Collections.Generic;
using System.Diagnostics;

public abstract class Goal
{
    private string _title;
    private string _description;
    private double _points;

    public Goal (string title, string description, double points)
    {
        _title = title;
        _description = description;
        _points = points;
    }

    public virtual string GetTitle(){
        return _title;
    }
    public virtual string GetDescription(){
        return _description;
    }
    public virtual double GetPoints()
    {
        return _points;
    }
    public abstract void IsCompleted();
    public abstract string Display();
}
