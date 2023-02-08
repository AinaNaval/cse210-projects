using System;

public abstract class Goal
{
    protected string _name = "";
    protected string _description = "";
    protected int _amountPoints;

    protected string _goalType;
    protected string _check = " ";

    public string GetGoalType()
    {
        return _goalType;
    }

    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
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

    public int GetAmountPoints()
    {
        return _amountPoints;
    }

    public void SetAmountPoints(int amountPoints)
    {
        _amountPoints = amountPoints;
    }


    public Goal(string name, string description, int amountPoints)
    {
        _name = name;
        _description = description;
        _amountPoints = amountPoints;
    }

    public Goal()
    {
        
    }

    public void AddValue(){
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _amountPoints = int.Parse(Console.ReadLine());
    }

    public virtual string ListGoals()
    {
        return $"[{_check}] {_name} ({_description})";
    }

    public abstract string WriteGoals();
}