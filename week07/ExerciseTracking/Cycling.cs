public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double hours = _length / 60.0;
        return _speed * hours;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling - Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km.";
    }
}