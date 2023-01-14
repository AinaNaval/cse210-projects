using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        string valueFromUser = Console.ReadLine();

        // Convert to a number 
        int x = int.Parse(valueFromUser);
        int y = 5;
        
        if (x > y)
        {
            Console.WriteLine("Greater");
        }
        else if (x < y)
        {
            Console.WriteLine("Less");
        }
        else 
        {
            Console.WriteLine("Equal");
        }
    }
}