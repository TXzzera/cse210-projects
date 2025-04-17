public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int length, double distance) : base(date,length)
    { 
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        double speed = (_distance/_length) *60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = _length / _distance;
        return pace;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running - Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km.";
    }
}