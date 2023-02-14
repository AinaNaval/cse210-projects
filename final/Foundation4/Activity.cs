using System;

public class Activity
{
    private string _date = "";
    protected int _length;

    protected string _activity = "";


    public Activity(string date, int length, string activity)
    {
        _date = date;
        _length = length;
        _activity = activity;
    }

    public virtual double Distance()
    {
        return 1;
    }

    public virtual double Speed()
    {
        return 1;
    }

    public virtual double Pace()
    {
        return 1;
    }

    public virtual string GetSummary()
    {
        return $"{_date} {_activity} ({_length} min): Distance {String.Format("{0:0.0}",Distance())} Km, Speed: {String.Format("{0:0.0}",Speed())} Kph, Pace: {String.Format("{0:0.0}",Pace())} min per Km";
    }
}