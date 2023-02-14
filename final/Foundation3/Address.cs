using System;

public class Address
{
    protected string _street = "";
    protected string _city = "";

    public Address(string street, string city)
    {
        _street = street;
        _city = city;
    }

    public string GetAddress()
    {
        return $"{_street} - {_city}";
    }
}