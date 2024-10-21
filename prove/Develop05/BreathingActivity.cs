namespace Develop05;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetActivityName("Breathing");
        SetActivityDescription(
            "This activity will help you relax by walking you through a breathing in and out slowly." +
            "Clear your mind and focus on your breathing.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetActivityDuration();

        while (duration > 0)
        {
            Console.Write("Breath in... ");

            // Get the minimum of the remaining time or 4 seconds
            int inhaleTime = Math.Min(duration, 4);
            
            ShowCountDown(inhaleTime);
            Console.WriteLine("");
            duration -= inhaleTime;

            if (duration > 0)
            {
                Console.Write("Now breath out... ");
                // Get the minimum of the remaining time or 6 seconds
                int exhaleTime = Math.Min(duration, 6);
                
                ShowCountDown(exhaleTime);
                Console.WriteLine("");
                duration -= exhaleTime;
            }

            Console.WriteLine("");
        }

        DisplayEndingMessage();
    }
}