using System;

public class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>();
    private List<Video> _videos = new List<Video>();

    public Video (string title, string author, double length, List<Comment>comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public void Numberofcomments()
    {
        Console.WriteLine($"Video Name: {_title}, Created by: {_author}, Length (min and seconds): {_length}, Quantity of comments: {_comments.Count}");
        string strComments;

        foreach (var comment in _comments)
        {
            strComments = comment.GetComments();
            Console.WriteLine(strComments);
        }
    }
}