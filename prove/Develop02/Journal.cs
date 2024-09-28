namespace Develop02;

using System.Web;

public class Journal
{
    public List<Entry> _entries = new();
 
    public void AddEntry (Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll ()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            // If the file already exists, overwrite it and write the header. Ask for confirmation.
            if (File.Exists(file))
            {
                Console.Write("File already exists. Overwrite? (y/n) ");
                string response = Console.ReadLine();
                
                if (response != "y")
                {
                    Console.WriteLine("File not saved.");
                    return;
                }
            }
            
            outputFile.WriteLine("Date,Prompt,Entry");
            
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{HttpUtility.UrlEncode(entry._date)},{HttpUtility.UrlEncode(entry._promptText)},{HttpUtility.UrlEncode(entry._entryText)}");
            }

            outputFile.Close();
        
        }
        
        Console.WriteLine("File saved successfully.");
    }
    
    public string GetAllCsvFiles()
    {
        string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.csv");
                
        Console.WriteLine("Select a file to load:");
        for (int i = 0; i < files.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {files[i]}");
        }
                
        Console.Write("Which file would you like to load? ");
        int fileIndex = int.Parse(Console.ReadLine()!);
        
        return files[fileIndex - 1];
    }

    public void LoadFromFile (string file)
    {
        _entries.Clear();
        
        StreamReader reader = new StreamReader(file);
        
        reader.ReadLine();
        
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            string[] values = line!.Split(',');
            
            Entry newEntry = new Entry
            {
                _date = HttpUtility.UrlDecode(values[0]),
                _promptText = HttpUtility.UrlDecode(values[1]),
                _entryText = HttpUtility.UrlDecode(values[2])
            };

            _entries.Add(newEntry);
        }
        
        reader.Close();
    }
}
 