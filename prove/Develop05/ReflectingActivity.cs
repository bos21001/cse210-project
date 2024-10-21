namespace Develop05;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        SetActivityName("Reflecting");
        SetActivityDescription("This activity will help you reflect on tines in life when you have sho..rn strength " +
                               "and resilience. This will help you recognize the power you have and how you can use " +
                               "it in other aspects of your life.");

        _prompts =
        [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        ];

        _questions =
        [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        ];
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"--- {_prompts[index]} ---");
    }

    private void GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        Console.Write($"> {_questions[index]} ");
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");

        GetRandomPrompt();
        Thread.Sleep(5000);
        Console.WriteLine("");

        Console.Write("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("");


        Console.Write("You may begin in: ");
        ShowCountDown(3);

        Console.Clear();
    }

    private void DisplayQuestions()
    {
        int duration = GetActivityDuration();

        int amountOfQuestions = duration / 10;

        if (duration < 10)
        {
            amountOfQuestions = 1;
        }

        for (int i = 0; i < amountOfQuestions; i++)
        {
            GetRandomQuestion();
            ShowSpinner(Math.Min(10, duration));
            duration -= 10;

            Console.WriteLine("");
        }
    }
}