using System;

public class Receptions : BaseEvent
{
    private string _email = "";

    public Receptions(string title, string description, string date, string time, string eventType, string address, string email) : base(title,description,date,time,eventType,address)
    {
        _email = email;
    }
    public string StandardReceptions()
    {
        return Standard();
    }

    public string FullReceptions()
    {
        return $"{Standard()}, email: {_email}";
    }

    public string ShortReceptions()
    {
        return ShortDescription();
    }
}