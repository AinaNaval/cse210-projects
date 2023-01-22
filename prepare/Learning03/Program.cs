using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f1.GerFractionString());
        
        Fraction f2 = new Fraction(3);
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f2.GerFractionString());

        Fraction f3 = new Fraction(2, 4);
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine(f3.GerFractionString());
    }
}