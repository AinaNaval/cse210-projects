using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> video = new List<Video>();

        Video v1 = new Video();
        v1._author = "4Flag";
        v1._title = "Headshoot tutorial(free fire)";
        v1._length = 400;
        video.Add(v1);

        Video v2 = new Video();
        v2._author = "White444";
        v2._title = "Perfect gloo wall placement(free fire)";
        v2._length = 340;
        video.Add(v2);

        Video v3 = new Video();
        v3._author = "B2K";
        v3._title = "How to use double AWM(free fire)";
        v3._length = 260;
        video.Add(v3);

        Comment c1 = new Comment();
        c1._name = "Clark";
        c1._comment = "Thank you for this video bro!!";
        c1._names.Add(c1._name);
        c1._comments.Add(c1._comment);
        c1._name = "Cali";
        c1._comment = "This is very helpfull!!";
        c1._names.Add(c1._name);
        c1._comments.Add(c1._comment);
        c1._name = "Cristiano";
        c1._comment = "Great video, add more!!";
        c1._names.Add(c1._name);
        c1._comments.Add(c1._comment);
        v1._allComments.Add(c1);

        Comment c2 = new Comment();
        c2._name = "Giovani";
        c2._comment = "Thanks for sharing!!";
        c2._names.Add(c2._name);
        c2._comments.Add(c2._comment);
        c2._name = "Jason";
        c2._comment = "Yeah bro, thanks for this tutorial!!";
        c2._names.Add(c2._name);
        c2._comments.Add(c2._comment);
        c2._name = "Norman";
        c2._comment = "This is cool, I really love it!!";
        c2._names.Add(c2._name);
        c2._comments.Add(c2._comment);
        v2._allComments.Add(c2);

        Comment c3 = new Comment();
        c3._name = "Jack";
        c3._comment = "After watching this video, I will use double AWM too!!";
        c3._names.Add(c3._name);
        c3._comments.Add(c3._comment);
        c3._name = "Marie";
        c3._comment = "You're amaizing bro, you are a pro player!!";
        c3._names.Add(c3._name);
        c3._comments.Add(c3._comment);
        c3._name = "Billy";
        c3._comment = "I have no objection, you are the best bro!!";
        c3._names.Add(c3._name);
        c3._comments.Add(c3._comment);
        v3._allComments.Add(c3);

        

        /*display*/
        foreach (Video v in video)
        {
            v.VideoInfo();
        }

    }
}