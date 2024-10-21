namespace Develop05;

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts;

    public ListingActivity()
    {
        SetActivityName("Listing");
        SetActivityDescription("This activity will help you reflect on the good things in your life by having you " +
                               "list as many things as you can in a certain area.");

        _prompts =
        [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        ];
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[index]} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(3);

        DateTime startTime = DateTime.Now;

        while (DateTime.Now - startTime < TimeSpan.FromSeconds(GetActivityDuration()))
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            _count++;
        }
        
        Console.WriteLine($"You listed {_count} items!");
    }
}