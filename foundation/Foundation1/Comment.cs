namespace Foundation1;

public class Comment
{
    public string _commenter;
    public string _text;
    
    public Comment(string commenter, string text)
    {
        _commenter = commenter;
        _text = text;
    }
    
    public string DisplayComment()
    {
        return $"Commenter: {_commenter}, Text: {_text}";
    }
}