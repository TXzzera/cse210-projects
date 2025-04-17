public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(DateTime date, int length, int numberOfLaps) : base (date,length)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50/1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance()/_length) * 60;
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming - Distance: {GetDistance():0.0} km {_numberOfLaps} Laps, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km.";
    }
}