using System;

public class Checklist : Goal
{
    private int _times;
    private int _bonus;
    private int _done = 0;

    public int GetDone()
    {
        return _done;
    }

    public void SetDone(int done)
    {
        _done = done;
    }


    public void AddValue3()
    {
        AddValue();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _times = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
    }

    public override string ListGoals()
    {
        return $"[{_check}] {_name} {_description} -- Currently Completed: {_done}/{_times}";        
    }

    public override string WriteGoals()
    {
        return $"{_goalType}:{_name},{_description},{_amountPoints},{_bonus},{_times},{_done}";
    }
}