using System;

public class Address
{
    private string _street = "";
    private string _city = "";
    private string _state = "";
    public string _country = "";
    private string _place = "In the USA";

    public List<string> _list = new List<string>();

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string VerifyCountry()
    {
        if (_country == "USA")
        {
            return _place;
        } 
        else
        {
            return $"Not {_place}";
        }
    }

    public string AllInfo()
    {
        string a = "street: " + _street + ", city: " +_city + ", state: " + _state + ", country: " + _country;
        _list.Add(a);
        return a;
    }
}