using System;

public class Comment
{
    private string _name;
    private string _textComment;

    public Comment(string name, string textComment)
    {
        _name = name;
        _textComment = textComment;
    }
    
    public string GetComments()
    {
        string nameComment = $"{_name}: {_textComment}";
        return nameComment;
    }
}
