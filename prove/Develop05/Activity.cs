namespace Develop05;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    protected Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    protected void SetActivityName(string name)
    {
        _name = name;
    }

    protected void SetActivityDescription(string description)
    {
        _description = description;
    }

    protected int GetActivityDuration()
    {
        return _duration;
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        
        Console.WriteLine("");

        Console.Write("How long in seconds would you like to do this activity? ");
        _duration = Convert.ToInt32(Console.ReadLine());
        // Clear the console
        Console.Clear();
        
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
        Console.WriteLine("");
        
        // Clear the console
        Console.Clear();
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!");
        
        ShowSpinner(3);
        
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string> {"/", "-", "\\", "|"};
        int totalSleepTime = 0;
        
        while (totalSleepTime < seconds * 1000)
        {
            foreach (string s in spinner)
            {
                Console.Write(s);
                Thread.Sleep(200);
                totalSleepTime += 200;
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }
        
        // Clear the spinner
        Console.Write(" ");
    }

    protected void ShowCountDown(int seconds)
    {
        Console.Write(seconds);
        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        
        for (int i = seconds - 1; i >= 0; i--)
        {
            Thread.Sleep(1000);
            Console.Write(i);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        
        // Clear the countdown
        Console.Write("   ");
    }
}