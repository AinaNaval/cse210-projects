using System;

class Program
{
    static void Main(string[] args)
    {
        // To determine the length of a list for example
        // list<string> words ---> words.count
        float number;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.WriteLine();
        
        List<float> listOfNumbers = new List<float>();

        do 
        {
            Console.Write("Enter a number: ");
            string num = Console.ReadLine();
            number = int.Parse(num);
            listOfNumbers.Add(number);

        } while (number != 0);
        
        float sum = 0; 
        
        for (int i = 0; i < listOfNumbers.Count; i++)
        {
            sum = sum + listOfNumbers[i];
        }
        Console.WriteLine($"The sum is: {sum}");
        
        float largest = listOfNumbers.Max();
        float average = listOfNumbers.Average();
        
        Console.WriteLine($"The average number is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}