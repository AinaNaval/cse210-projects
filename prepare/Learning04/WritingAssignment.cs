using System;

public class Writing : Assignment
{
    private string _title = "";

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public Writing() : base()
    {

    }

    public Writing(string title, string name, string topic) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        return $"{_title} by {_studentName}";
    }

}