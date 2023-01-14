using System;

class Program
{
    static void Main(string[] args)
    {
        //Do-while
        /*string input;

        do
        {
            Console.Write("Do you want to continue? ");
            input = Console.ReadLine();
        } while (input == "yes");*/

        int number;
        int userGuess;

            Console.Write("What is the magic number? ");
            string magicNumber = Console.ReadLine();
            number = int.Parse(magicNumber);
        do
        {
            Console.Write("What is your guess? ");
            string userNumber = Console.ReadLine();
            userGuess = int.Parse(userNumber);
            
            if (userGuess > number)
            {
                Console.WriteLine("Less");
            } 
            else if (userGuess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it");
            }
        } while (number != userGuess);
    }
}