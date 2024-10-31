namespace Develop06;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, string points, bool isComplete = false) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string escapedName = Uri.EscapeDataString(_shortName);
        string escapedDescription = Uri.EscapeDataString(_description);
        string escapedPoints = Uri.EscapeDataString(_points.ToString());
        string escapedIsComplete = Uri.EscapeDataString(_isComplete.ToString());

        return $"SimpleGoal:{escapedName};{escapedDescription};{escapedPoints};{escapedIsComplete}";
    }
}