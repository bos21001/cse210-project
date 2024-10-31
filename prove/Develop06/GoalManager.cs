namespace Develop06;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        // This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine($"You Have {_score} points.");
            Console.WriteLine("");
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List goals");
            Console.WriteLine("  3. Save goals");
            Console.WriteLine("  4. Load goals");
            Console.WriteLine("  5. Record event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalsDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    DisplayPlayerInfo();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalsNames()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"   {index}. {goal.GetName()}");
            index++;
        }
    }

    public void ListGoalsDetails()
    {
        Console.WriteLine("The goals are:");
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }
        
        Console.WriteLine("");
    }

    public void CreateGoal()
    {
        Console.WriteLine("The type of goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        switch (goalType)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    public void RecordEvent()
    {
        ListGoalsNames();
        Console.Write("Which goal have you completed? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            if (!_goals[goalIndex].IsComplete())
            {
                _goals[goalIndex].RecordEvent();
                _score += _goals[goalIndex].GetPoints();
            }
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter the file name to save the goals to: ");
        string fileName = Console.ReadLine();
        
        // clean up the file if it already exists
        if (File.Exists(fileName))
        {
            File.Delete(fileName);
        }
        
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("Enter the file name to load the goals from: ");
        string fileName = Console.ReadLine();
        
        _goals.Clear();

        using (StreamReader reader = new StreamReader(fileName))
        {
            // get the total amount of lines in the file
            int totalLines = File.ReadLines(fileName).Count();

            _score = int.Parse(reader.ReadLine());

            for (int i = 0; i < totalLines; i++)
            {
                string goalString = reader.ReadLine();

                if (goalString != null)
                {
                    string[] parts = goalString.Split(';');

                    string goalType = parts[0].Split(":")[0];
                    string name = Uri.UnescapeDataString(parts[0].Split(":")[1]);
                    string description = Uri.UnescapeDataString(parts[1]);
                    string points = Uri.UnescapeDataString(parts[2]);

                    switch (goalType)
                    {
                        case "SimpleGoal":
                            bool isComplete = bool.Parse(parts[3]);
                            _goals.Add(new SimpleGoal(name, description, points, isComplete));
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(name, description, points));
                            break;
                        case "CheckListGoal":
                            int bonus = int.Parse(parts[3]);
                            int target = int.Parse(parts[4]);
                            int amountCompleted = int.Parse(parts[5]);
                            _goals.Add(new ChecklistGoal(name, description, points, target, bonus, amountCompleted));
                            break;
                        default:
                            Console.WriteLine("Invalid goal type.");
                            break;
                    }
                }
            }
        }
    }
}