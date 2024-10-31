namespace Develop06;

public class EternalGoal: Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string escapedName = Uri.EscapeDataString(_shortName);
        string escapedDescription = Uri.EscapeDataString(_description);
        string escapedPoints = Uri.EscapeDataString(_points.ToString());

        return $"EternalGoal:{escapedName};{escapedDescription};{escapedPoints}";
    }
}