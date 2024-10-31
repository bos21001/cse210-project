namespace Develop06;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
    
    public int GetPoints()
    {
        return int.Parse(_points);
    }
    
    public void SetPoints(string points)
    {
        _points = points;
    }
    
    public string GetName()
    {
        return _shortName;
    }
}