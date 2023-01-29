using System;

public class Listing : Activity
{
    private string _question1 = "";

    public string GetResponse()
    {
        return _question1;
    }

    public void SetResponse(string question1)
    {
        _question1 = question1;
    }

    public Listing(int duration, string name) : base(duration, name)
    {
        
    }

    public void StartListing()
    {
        List<string> questions = new List<string>();
        questions.Add("Who are people that you appreciate?");
        questions.Add("What are personal strengths of yours?");
        questions.Add("Who are people that you have helped this week?");
        questions.Add("When have you felt the Holy Ghost this month?");
        questions.Add("Who are some of your personal heroes?");

        Random randomQuestion = new Random();
        int questionsCount = questions.Count();
        int num = randomQuestion.Next(0, questionsCount);
        _question1 = questions[num];

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"--- {_question1} ---");
        Console.Write("You may begin in: ");

        int a = 5;
        while (a >= 1)
        {
            Console.Write($"{a}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            a--;
        }
        Console.WriteLine();

        int b = 0;
        while (currentTime < futureTime)
        {
            Console.ReadLine();
            
            DateTime rightNow = DateTime.Now;
            currentTime = rightNow;
            b++;
        }

        Console.WriteLine($"You listed {b} items!");
        Console.WriteLine();
    }
}