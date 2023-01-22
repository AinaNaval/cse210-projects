using System;

public class Scripture
{
    private string _text = "";

    public Scripture()
    {
        _text = "Trust in the Lord with all thine heart and lean not unto thine ownz understanding; in all thy ways acknowledge him, and he shall direct thy paths";
    }
    
    public string GetScripture()
    {
        return _text;
    }
}