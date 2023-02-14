using System;

public class Lecture :  BaseEvent
{
    private string _name = "";
    private string _capacity = "";
    
    public Lecture(string title, string description, string date, string time, string eventType, string address, string name, string capacity) : base(title,description,date,time,eventType,address)
    {
        _name = name;
        _capacity = capacity;
    }

    public string StandardLecture()
    {
        return Standard();
    }

    public string FullLecture()
    {
        return $"{Standard()}, Speaker name: {_name}, Capacity: {_capacity}";
    }

    public string ShortLecture()
    {
        return ShortDescription();
    }
}