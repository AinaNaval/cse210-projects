using System;

public class Eternal : Goal
{
    
    public void AddValue2()
    {
        AddValue();
    }

    public override string WriteGoals()
    {
        return $"{_goalType}:{_name},{_description},{_amountPoints}";
    }
}
