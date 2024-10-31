namespace Develop06;

public class ChecklistGoal : Goal
{
    private int _target;
    private int _bonus;
    private int _amountCompleted;

    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted = 0)
        : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target - 1)
        {
            _amountCompleted++;
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points");
        }
        if (_amountCompleted == _target - 1)
        {
            _amountCompleted++;
            SetPoints((int.Parse(_points) + _bonus).ToString());

            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points");
        }
        else
        {
            Console.WriteLine("You have already completed this goal the maximum number of times.");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description}) -- Currently completed: " +
               $"{_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        string escapedName = Uri.EscapeDataString(_shortName);
        string escapedDescription = Uri.EscapeDataString(_description);
        string escapedPoints = Uri.EscapeDataString(_points);

        return
            $"CheckListGoal:{escapedName};{escapedDescription};{escapedPoints};{_bonus};{_target};{_amountCompleted}";
    }
}