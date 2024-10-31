namespace Foundation3;

public abstract class Activity
{

    private DateTime _date;
    private int _duration;


    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }


    public DateTime Date => _date;
    public int Duration => _duration;


    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();


    public virtual string GetSummary()
    {
        return
            $"{Date:dd MMM yyyy} {GetType().Name} ({Duration} min): Distance: {GetDistance():F1}, Speed: {GetSpeed():F1}, Pace: {GetPace():F2}";
    }
}