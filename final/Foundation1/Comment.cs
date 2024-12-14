using System;

public class Comment
{
    private string _commenterName;
    private string _comment;

    public void SetCommenterName(string commenterName)
    {
        _commenterName = commenterName;
    }

    public void SetComment(string comment)
    {
        _comment = comment;
    }

    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetComment()
    {
        return _comment;
    }

    
}