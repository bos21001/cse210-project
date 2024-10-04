namespace Develop03;

public class Scripture
{
    private readonly Reference _reference;
    private List<Word> _words = new List<Word>();
    private List<int> _notHiddenIndexes = new List<int>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        InitializeWords(text);
    }

    private void InitializeWords(string text)
    {
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
            _notHiddenIndexes.Add(_words.Count - 1);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            if (_notHiddenIndexes.Count == 0) break;

            int randomIndex = random.Next(0, _notHiddenIndexes.Count);
            _words[_notHiddenIndexes[randomIndex]].Hide();
            _notHiddenIndexes.RemoveAt(randomIndex);

            if (IsCompletelyHidden())
            {
                break;
            }
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}: {string.Join(" ", _words.Select(word => word.GetDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}