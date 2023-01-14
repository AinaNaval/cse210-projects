using System;

public class Track
{
    public string _question;
    public string _answer;
    public string _date;
    public void DisplayInfo()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_question}");
        Console.WriteLine($"{_answer}");
    }
}
