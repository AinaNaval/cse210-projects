using System;

class Program

{
    static void Main(string[] args)
    {
        DisplayWelcome();

        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        PromptUserName(name);

        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        PromptUserNumber(num);

        SquareNumber(num);

        DisplayResult(PromptUserName(name), SquareNumber(num));
        
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName(string name)
    {
        return name;
    }
    static int PromptUserNumber(int num)
    {
        return num;
    }
    static int SquareNumber(int num2)
    {
        int squared = num2 * num2;
        return squared; 
    }
    static void DisplayResult( string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}