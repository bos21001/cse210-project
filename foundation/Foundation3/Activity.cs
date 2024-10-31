namespace Foundation3;

// Base class for all activities
public abstract class Activity
{
    // Private member variables
    private DateTime _date;
    private int _duration; // in minutes

    // Constructor
    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    // Properties
    public DateTime Date => _date;
    public int Duration => _duration;

    // Virtual methods for distance, speed, and pace
    public abstract double GetDistance();
    public abstract double GetSpeed(); // in mph or kph
    public abstract double GetPace(); // in min per mile or min per km

    // Summary method
    public virtual string GetSummary()
    {
        return
            $"{Date:dd MMM yyyy} {GetType().Name} ({Duration} min): Distance: {GetDistance():F1}, Speed: {GetSpeed():F1}, Pace: {GetPace():F2}";
    }
}