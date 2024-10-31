namespace Foundation3;

public class Cycling : Activity
{
    private double _speed; // in mph

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance() => (GetSpeed() * Duration) / 60; // miles

    public override double GetSpeed() => _speed; // mph

    public override double GetPace() => 60 / GetSpeed(); // min per mile
}