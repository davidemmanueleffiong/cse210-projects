using System.Collections.Generic;

public class Video
{
    private readonly string _title;
    private readonly string _author;
    private readonly int _lengthSeconds;
    private readonly List<Comment> _comments;

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _lengthSeconds;
    }

    public IReadOnlyList<Comment> GetComments()
    {
        return _comments;
    }
}
