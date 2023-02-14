using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activity = new List<Activity>();

        Running running = new Running("12 Septembre 2022", 30, "Running", 3);
        activity.Add(running);

        Cycling cycling = new Cycling("3 February 2023", 30, "Cycling", 3.6);
        activity.Add(cycling);

        Swimming swimming = new Swimming("26 June 2022", 30, "Swimming", 7);
        activity.Add(swimming);

        foreach (Activity act in activity)
        {
            Console.WriteLine(act.GetSummary());
        }
        
    }
}