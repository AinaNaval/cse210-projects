using System;

public class Activity
{
    private string _name = "";
    private string _description = "";
    protected int _duration;
    
    public string GetDuration()
    {
        return _duration.ToString();
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public string Getname()
    {
        return _name;
    }

    public void Setname(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public Activity(int duration, string name)
    {
        _name = name;
        _duration = duration;
    }
    public Activity(string description, string name)
    {
        _name = name;
        _description = description;
    }

    public string DisplayActivity()
    {
        return $"Welcom to the {_name}\n\n{_description}";
    }

    public void GetReady()
    {
        Console.WriteLine("Get ready...");
        Thread.Sleep(5000);
        Console.WriteLine();
    }

    public void Ending()
    {
        Console.WriteLine("Well Done!!");
        Thread.Sleep(5000);
        Console.WriteLine();

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        Thread.Sleep(5000);
        Console.Clear();
    }
}
