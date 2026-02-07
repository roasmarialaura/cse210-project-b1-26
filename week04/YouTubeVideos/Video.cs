using System;
using System.Collections.Generic;
class Video
{
    private string _title;
    private string _author;

    private int _length;
    private List<Comment> _comments;
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    } 
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} minutes");
        Console.WriteLine($"Total comments: {ReturnNumComments()}");
    }
    public int ReturnNumComments()
    {
        return _comments.Count;
    }
    public void DisplayAllComments()
    {
        foreach (var comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}