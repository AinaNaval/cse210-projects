using System;

public class Reference
{
    private string _bookName = "";
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference()
    {
        _bookName = "Proverbs";
        _chapter = 3;
        _verse = 5;
        _endVerse = 6;
    }

    public String GetReference()
    {
        return _bookName + " " + _chapter + ":" + _verse + "-" + _endVerse + " ";
    }

}