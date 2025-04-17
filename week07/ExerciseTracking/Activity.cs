using System;
using System.Globalization;

public abstract class Activity
{
    public DateTime _date {get; private set;}
    public int _length {get; private set;} // Duration in minutes

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }
    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd/MMMM/yyyy", CultureInfo.CreateSpecificCulture("en-US"))} Duration: {_length} min";
    }
}
