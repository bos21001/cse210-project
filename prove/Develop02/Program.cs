namespace Develop02;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        List<string> prompts = [
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        ];
        promptGenerator._prompts = prompts;
        
        string userInput = "0";

        while (userInput != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                // Write
                Entry newEntry = new Entry();
                
                newEntry._date = DateTime.Now.ToString("yyyy-MM-dd");
                newEntry._promptText = promptGenerator.GetRandomPrompt();
                
                Console.WriteLine(newEntry._promptText);
                Console.Write("> ");
                
                newEntry._entryText = Console.ReadLine();
                
                journal.AddEntry(newEntry);
            } 
            else if (userInput == "2")
            {
                // Display
                journal.DisplayAll();
            }
            else if (userInput == "3")
            {
                // Load
                string filename = journal.GetAllCsvFiles();
                
                journal.LoadFromFile(filename);
            }
            else if (userInput == "4")
            {
                // Save
                Console.WriteLine("What is the filename? (e.g. journal.csv)");
                string filename = Console.ReadLine();
                
                journal.SaveToFile(filename);
            }
            else if (userInput == "5")
            {
                Console.WriteLine("Goodbye!");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                // wait for 1 second
                Thread.Sleep(1000);
            }
        }
    }
}