using System;

public class Comment
{
    public string _name = "";
    public string _comment = "";
    public List<String> _names = new List<string>();

    public List<String> _comments = new List<string>();

    public void display()
    {
        Console.WriteLine($"Comments({_names.Count()}):");
        int i = 0;
        while (i < _names.Count())
        {
            Console.WriteLine($"by {_names[i]}: '{_comments[i]}'");
            i++;
        }
    }
            

}