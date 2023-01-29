using System;

public class Reflecting : Activity
{
    private string _prompt = "";
    private string _question = "";

    public string GetPrompt()
    {
        return _prompt;
    }

    public void SetPrompt(string prompt)
    {
        _prompt = prompt;
    }

    public string GetQuestion()
    {
        return _question;
    }

    public void SetQuestion(string question)
    {
        _question = question;
    }

    public Reflecting(int duration, string name) : base(duration, name)
    {

    }

    public void StartReflecting()
    {
        List<string> promptList = new List<string>();
        List<string> questionList = new List<string>();

            promptList.Add("Think of a time when you stood up for someone else.");
            promptList.Add("Think of a time when you did something really difficult.");
            promptList.Add("Think of a time when you helped someone in need.");
            promptList.Add("Think of a time when you did something truly selfless.");

            questionList.Add("Why was this experience meaningful to you? ");
            questionList.Add("Have you ever done anything like this before? ");
            questionList.Add("How did you get started? ");
            questionList.Add("How did you feel when it was complete? ");
            questionList.Add("What made this time different than other times when you were not as successful? ");
            questionList.Add("What is your favorite thing about this experience? ");
            questionList.Add("What could you learn from this experience that applies to other situations? ");
            questionList.Add("What did you learn about yourself through this experience? ");
            questionList.Add("How can you keep this experience in mind in the future? ");

        Random randomPrompt = new Random();
        int promptListCount = promptList.Count();
        int num = randomPrompt.Next(0, promptListCount);
        _prompt = promptList[num];

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"--- {_prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");

        int a = 5;
        while (a >= 1)
        {
            Console.Write($"{a}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            a--;
        }
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            Random randomQuestion = new Random();
            int questionListCount = questionList.Count();
            int num2 = randomQuestion.Next(0, questionListCount);
            _question = questionList[num2];

            Console.Write(_question);
            Console.ReadLine();

            DateTime now = DateTime.Now;
            currentTime = now;
        }
        Console.WriteLine();
    }

}