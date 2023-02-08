using System;

public class Simple : Goal
{
    private string _checked = "False";

    public string GetChecked()
    {
        return _checked;
    }

    public void SetChecked(string Gchecked)
    {
        _checked = Gchecked;
    }

    public void AddValue1()
    {
        AddValue();
    }

    public override string WriteGoals()
    {
        return $"{_goalType}:{_name},{_description},{_amountPoints},False";
    }
}
