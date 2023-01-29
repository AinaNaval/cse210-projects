using System;

class Program
{
    static void Main(string[] args)
    {
        /*Assignment a1 = new Assignment();
        a1.SetName("Cristiano Ronaldo");
        a1.SetTopic("Division");

        Console.WriteLine(a1.GetSummary());*/

        MathAssignment m1 = new MathAssignment("Roberto Rodrigez", "Fractions", "7.3", "8-19");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());

        Writing w1 = new Writing("The Causes of World War II", "Mary Waters", "European History");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInfo());
        
    }
}