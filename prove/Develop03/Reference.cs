namespace Develop03;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }
    
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    
    public Reference(List<string> reference)
    {
        _book = reference[0];
        _chapter = int.Parse(reference[1]);
        string[] verses = reference[2].Split('-');
        _verse = int.Parse(verses[0]);
        _endVerse = verses.Length == 2 ? int.Parse(verses[1]) : _verse;
    }
    
    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}