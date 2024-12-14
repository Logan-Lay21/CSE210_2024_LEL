using System;
using System.Security.Cryptography.X509Certificates;

public class Video {
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new();

    public Video (string title, string author, int length) {
        _title = title;
        _author = author;
        _length = length;
    }
    
    public void StoreComment(string commenterName, string comment) {
        Comment newComment = new();
        newComment.SetCommenterName(commenterName);
        newComment.SetComment(comment);
        _comments.Add(newComment);
    }

    public int GetCommentCount(List<Comment> comments) {
        return comments.Count;
    }

    public string Report() {
        string report = $"{_title} by {_author} ({_length} seconds)\n";
        foreach (Comment comment in _comments) {
            report += $"{comment.GetCommenterName()}: {comment.GetComment()}\n";
        }
        return report;
    }
    
}