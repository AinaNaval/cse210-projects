using System;

public class Breathing : Activity
{
    private string _in = "";
    private string _out = "";

    public string GetIn()
    {
        return _in;
    }

    public void SetIn(string breathIn)
    {
        _in = breathIn;
    }

    public string GetOut()
    {
        return _out;
    }

    public void SetOut(string breathOut)
    {
        _in = breathOut;
    }
    
    public Breathing(int duration, string name) : base(duration, name)
    {
        _in = "Breathing in ...";
        _out = "Now breathe out ...";
    }

    public void StartBreathing()
    {
        DateTime StartTime = DateTime.Now;
        DateTime futureTime = StartTime.AddSeconds(_duration);
        
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            Console.Write(_in);
            int a = 4;
            while (a >= 1)
            {
                Console.Write($"{a}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                a--;
            }

            int b = 6;
            Console.WriteLine();
            Console.Write(_out);
            while (b >= 1)
            {
                Console.Write($"{b}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                b--;
            }
            Console.WriteLine();
            Console.WriteLine();

            DateTime timeNow = DateTime.Now;
            currentTime = timeNow;
        }
    }

}