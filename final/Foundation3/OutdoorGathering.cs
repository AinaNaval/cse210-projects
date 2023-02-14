using System;

public class OutdoorGathering : BaseEvent
{
    private string _weatherStatement = "";

    public OutdoorGathering(string title, string description, string date, string time, string eventType, string address, string weatherStatement) : base(title,description,date,time,eventType,address)
    {
        _weatherStatement = weatherStatement;
    }

    public string StandardOutdoor()
    {
        return Standard();
    }

    public string FullOutdoor()
    {
        return $"{Standard()}, Weather Statement: {_weatherStatement}";
    }

    public string ShortOutdoor()
    {
        return ShortDescription();
    }
}