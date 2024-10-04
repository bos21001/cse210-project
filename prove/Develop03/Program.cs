namespace Develop03;

class Program
{
    static void Main(string[] args)
    {
        // Reference reference = new Reference("John", 3, 16);
        // Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        
        ScripturesList scripturesList = new ScripturesList();
        scripturesList.SelectRandomScripture();
        
        Reference reference = new Reference(scripturesList.ReturnReferenceList());
        Scripture scripture = new Scripture(reference, scripturesList.ReturnScriptureText());
        
        string quit = "";

        while (!scripture.IsCompletelyHidden() && quit != "quit")
        {
            Console.WriteLine(scripture.GetDisplayText());
            scripture.HideRandomWords(4);

            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Congratulations! You have hidden all the words.");
                
                Console.Clear();
                
                Console.WriteLine(scripture.GetDisplayText());
            }
            else
            {
                Console.WriteLine();

                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                quit = Console.ReadLine()!.Trim().ToLower();
                
                if (quit != "quit")
                {
                    Console.Clear();
                }
            }
        }
    }
}