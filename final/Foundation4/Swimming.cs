using System;

public class Swimming : Activity
{
    private int _lap;

    public Swimming(string date, int length, string activity, int lap) : base(date,length,activity)
    {
        _lap = lap;
    }

    public override double Distance()
    {
        double i = _lap * 50;
        return i / 1000;
    }

    public override double Speed()
    {
        return (Distance() / _length) * 60;
    }

    public override double Pace()
    {
        return _length / Distance();
    }

    public override string GetSummary()
    {
        return base.GetSummary();
    }
}