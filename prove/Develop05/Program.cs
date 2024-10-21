namespace Develop05;

class Program
{
    static void Main(string[] args)
    {
        int menuSelection = 0;

        while (menuSelection != 4)
        {
            Console.Clear();

            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select an activity: ");
            menuSelection = Convert.ToInt32(Console.ReadLine());

            if (menuSelection == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (menuSelection == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (menuSelection == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
        }
    }
}