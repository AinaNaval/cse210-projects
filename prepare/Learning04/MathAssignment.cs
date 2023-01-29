using System;

public class MathAssignment : Assignment
{
    private string _textBookSection = "";
    private string _problems = "";


    public MathAssignment() : base()
    {

    }

    
    public MathAssignment(string name, string topic, string text, string problems) : base(name, topic)
    {
        _textBookSection = text;
        _problems = problems;
    }


    public string GetTextBookSection()
    {
        return _textBookSection;
    }

    public void SetTextBookSection(string text)
    {
        _textBookSection = text;
    }

    public string GetProblems()
    {
        return _problems;
    }

    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}