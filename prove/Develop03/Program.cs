using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>();
        string userChoice;
        Console.WriteLine("Proverbs 3:5-6 Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths");
        
        do {
        
        List<string> wordList = new List<string>();
        
        Console.WriteLine("Press Enter to continue or 'quit' to finish: ");
        userChoice = Console.ReadLine();
        Console.Clear();

        Reference r = new Reference();
        string reference = r.GetReference();

        Scripture s = new Scripture();
        string text = s.GetScripture();

        Char[] chars = {';','.',',',' '}; 
        String[] word = text.Split(chars, StringSplitOptions.RemoveEmptyEntries);
        foreach (string x in word)
        {
            wordList.Add(x);
        }


        Random randomWord = new Random();
        int count = wordList.Count();
        int num = randomWord.Next(0, count);
        int num2 = randomWord.Next(0, count);
        int num3 = randomWord.Next(0, count);
        number.Add(num);
        number.Add(num2);
        number.Add(num3);

        int numberCount = number.Count();
        string hiddenWord = ""; 

        foreach (int e in number)
            {
                string pickedWord = wordList[e];
                int num4 = pickedWord.Count();
                int b = 0;
                while (b < num4)
                {
                    hiddenWord = hiddenWord + "_";
                    b++;
                }
                wordList[e] = hiddenWord;
                hiddenWord = "";
            }  

        int j = 0;
        string part1 = "";
        while (j < 14)
        {
            part1 = part1 + wordList[j] + " ";
            j++;
        }

        string part2 = wordList[14] + "; ";

        int k = 15;
        string part3 = "";
        while (k < 20)
        {
            part3 = part3 + wordList[k] + " ";
            k++;
        }

        string part4 = wordList[20] + ", ";

        int l = 21;
        string part5 = "";
        while (l < (count-1))
        {
            part5 = part5 + wordList[l] + " ";
            l++;
        }

        string part6 = wordList[count -1] + ".";

        Combined all = new Combined();
        all._first = part1;
        all._second = part2;
        all._third = part3;
        all._fourth = part4;
        all._fifth = part5;
        all._last = part6;

        string combined = all.GetCombinedString();

        Console.WriteLine(reference + combined);

        }
        while (userChoice != "quit"); 
    }
}