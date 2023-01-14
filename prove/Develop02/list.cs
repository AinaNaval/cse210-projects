using System;

public class Update
{
    public List<Track> _data = new List<Track>();

    public void DisplayInfo2()
    {
        foreach (Track data in _data)
        {
            data.DisplayInfo();
        }
    }
}