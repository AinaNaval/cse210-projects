using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    
    {
        int userChoice; 
        List<string> questions = new List<string>();
        List<string> allData = new List<string>();
        List<string> fileNames = new List<string>();

        questions.Add("Who was the most interesting person I interacted with today? ");
        questions.Add("What was the best part of my day? ");
        questions.Add("How did I see the hand of the Lord in my life today? ");
        questions.Add("What was the strongest emotion I felt today? ");
        questions.Add("If I had one thing I could do over today, what would it be? ");

        do{

        Random randomQuestion = new Random();
        int num = randomQuestion.Next(0, 5);
        string question = questions[num];

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("What would you like to do? ");
        userChoice = int.Parse(Console.ReadLine());

        if (userChoice == 1)
        {
            Track info = new Track();
            info._question = question;
            info._date = DateTime.Now.ToString("MM/dd/yyyy");

            Update dataInfo1 = new Update();
            Console.WriteLine(info._question);
            info._answer = Console.ReadLine();
            dataInfo1._data.Add(info);
            // dataInfo1.DisplayInfo2();

            int b = fileNames.Count();
            if (b == 0)
            {
            
            StreamWriter sw = File.CreateText("C:\\Users\\Aina Naval\\Documents\\BYU Idaho\\Programmin with Classes\\Project\\cse210-projects\\prove\\Develop02\\try.txt");
            sw.WriteLine($"Date: {info._date} - Prompt: {info._question}");
            sw.WriteLine($"{info._answer}");
            sw.Close();

            string filename = "try.txt";
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                allData.Add(line);
            }
            
            }
            else
            {
                //The code here doesn't work 
                // It's says that the file is already used
                string openPrevFile = fileNames[0];
                StreamWriter sw2 = new StreamWriter(openPrevFile);
                sw2.WriteLine($"Date: {info._date} - Prompt: {info._question}");
                sw2.WriteLine($"{info._answer}");
            }
            

        }
        else if (userChoice == 2)
        {   
            int b = fileNames.Count();
            if (b == 0)
            {
                int i = 0;
                int n = allData.Count();
                while (i < n)
                {
                    Console.WriteLine($"{allData[i]}");
                    i++;
                }
            }
            else 
            {
                string openFile = fileNames[0];
                string[] lines = System.IO.File.ReadAllLines(openFile);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            
        }
        else if (userChoice == 3)
        {
            Console.WriteLine("What is the filename? ");
            string loadFile = Console.ReadLine();
            fileNames.Add(loadFile);
            
        }
        else if (userChoice == 4)
        {
            Console.WriteLine("What is the filename? ");
            string userFilename = Console.ReadLine();
            StreamWriter sw1 = File.CreateText($"C:\\Users\\Aina Naval\\Documents\\BYU Idaho\\Programmin with Classes\\Project\\cse210-projects\\prove\\Develop02\\{userFilename}.txt");
            int i = 0;
            int n = allData.Count();
            while (i < n)
            {
                sw1.WriteLine($"{allData[i]}");
                i++;
            }
            sw1.Close();
        }

        } while (userChoice != 5);
    } 
}