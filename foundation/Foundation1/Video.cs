﻿namespace Foundation1;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;
    
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    
    public int GetCommentCount()
    {
        return _comments.Count;
    }
    
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    
    public string DisplayDetails()
    {
        return $"Title: {_title}, Author: {_author}, Length: {_length}";
    }
}