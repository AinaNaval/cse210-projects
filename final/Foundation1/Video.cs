using System;

public class Video
{
    public string _title = "";
    public string _author = "";
    public int _length;

    public List<Comment> _allComments = new List<Comment>();

    public void VideoInfo()
    {
        Console.WriteLine($"Video: {_title} - by {_author} ({_length} s)");
        foreach (Comment com in _allComments)
        {
            com.display();
        }
        Console.WriteLine();
    }
}