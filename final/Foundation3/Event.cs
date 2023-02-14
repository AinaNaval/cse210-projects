using System;

public class BaseEvent 
{
    protected string _title = "";
    protected string _description = "";
    protected string _date = "";
    protected string _time;
    protected string _address = "";
    protected string _eventType = "";

    public List<Address> _addressList = new List<Address>();

    public BaseEvent()
    {

    }

    public BaseEvent(string title, string description, string date, string time, string eventType, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _eventType = eventType;
        _address = address;
    }

    public string Standard()
    {
        return $"Title: {_title}, Description: {_description}, Date: {_date}, Time: {_time}, Address: {_address}";
    }

    public string ShortDescription()
    {
        return $"Event type: {_eventType}, Title: {_title}, Date: {_date}";
    }
}