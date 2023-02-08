using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goalLists = new List<Goal>();
        List<string> fileLists = new List<string>();
        List<int> numLists = new List<int>();
        List<string> nameLists = new List<string>();
        List<int> points = new List<int>();
        List<string> types = new List<string>();
        List<int> timesL = new List<int>();
        int Done;
        int choice;
        int point = 0;
        int finishedGoal = 0;
        string filename1 = "";
        string filename = "";
        string check1 = " ";
        string check2 = " ";
        string check3 = " ";

        do 
        {
            Console.WriteLine();
            Console.WriteLine($"You have {point} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            int goalChoice;
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            goalChoice = int.Parse(Console.ReadLine());

            if (goalChoice == 1)
            {
                Simple g1 = new Simple();
                g1.SetGoalType("SimpleGoal");
                g1.AddValue1();
                goalLists.Add(g1);
            }

            if (goalChoice == 2)
            {
                Eternal g2 = new Eternal();
                g2.SetGoalType("EternalGoal");
                g2.AddValue2();
                goalLists.Add(g2);
            }
            if (goalChoice == 3)
            {
                Checklist g3 = new Checklist();
                g3.SetGoalType("ChecklistGoal");
                g3.AddValue3();
                goalLists.Add(g3);
            }
        }

        else if (choice == 2)
        {
            int fileCount = fileLists.Count();

            Console.WriteLine("The goals are:");

            if (fileCount == 0)
            {
            foreach (Goal goal in goalLists)
                {
                    int index = goalLists.IndexOf(goal);
                    Console.WriteLine($"{index + 1}. {goal.ListGoals()}");
                } 
            }else
            {
                string openFile = fileLists[0];
                string[] lines = System.IO.File.ReadAllLines(openFile);
                int i = 1;
                foreach (string line in lines)
                {
                    Char[] myChars = {',',':'};
                    string[] parts = line.Split(myChars);
                    string goalType = parts[0];
                    if (goalType == "0")
                    {}
                    else{
                    string name = parts[1];
                    string description = parts[2];
                    int amountPoints = int.Parse(parts[3]);

                    Console.Write($"{i}. ");
                    types.Add(goalType);
                    numLists.Add(i);
                    nameLists.Add(name);
                    points.Add(amountPoints);
                    if (line == "0")
                    {}
                    else {
                    if (goalType == "SimpleGoal")
                    {
                        Console.WriteLine($"[{check1}] {name} ({description})");
                    }else if (goalType == "EternalGoal")
                    {
                        Console.WriteLine($"[{check2}] {name} ({description})");
                    }else if (goalType == "ChecklistGoal")
                    {
                        int bonus = int.Parse(parts[4]);
                        int times = int.Parse(parts[5]);
                        timesL.Add(times);
                        int done = int.Parse(parts[6]);
                        Done = done;

                        Console.WriteLine($"[{check3}] {name} ({description}) -- Currently Completed: {done}/{times}");
                    }
                    
                    i++;
                    }
                    }
                    
                }
            }
        }

        else if (choice == 3)
        {
            Console.Write("What is the filename for the goal? ");
            filename = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine($"{point}");
                foreach (Goal goal in goalLists)
                {
                    outputFile.WriteLine($"{goal.WriteGoals()}");
                }
                
            }

        }

        else if (choice == 4)
        {
            Console.Write("What is the filename of the goal file? ");
            filename1 = Console.ReadLine();
            fileLists.Add(filename1);
        }

        else if (choice == 5)
        {
            Console.WriteLine("Which goal did you accomplish? ");
            int goalDone = int.Parse(Console.ReadLine());
            foreach (int num in numLists)
            {
                if (num == goalDone)
                {
                    int index = numLists.IndexOf(num);
                    int newPoint = points[index];
                    point = point + newPoint; 
                    if (types[index] == "SimpleGoal")
                    {
                        check1 = "X";
                        Console.WriteLine($"Congratulations! You have earned {newPoint} points!");
                        Console.WriteLine($"You now have {point} points");
                    } else if (types[index] == "EternalGoal")
                    {
                        check2 = "";
                        Console.WriteLine($"Congratulations! You have earned {newPoint} points!");
                        Console.WriteLine($"You now have {point} points");
                    }else if (types[index] == "ChecklistGoal")
                    {
                        finishedGoal = finishedGoal + 1;
                        Done = finishedGoal;
                        if (Done <= timesL[0])
                        {
                            Console.WriteLine($"Congratulations! You have earned {newPoint} points!");
                            Console.WriteLine($"You now have {point} points");
                        } else 
                        {
                            check3 = "X";
                            Console.WriteLine("Bingo!!");
                            Console.WriteLine($"Congratulations! You have earned {newPoint} points!");
                            Console.WriteLine($"You now have {point} points");
                        }
                        
                    }
                }
            }

        }
        
        } while (choice != 6);
    }
}