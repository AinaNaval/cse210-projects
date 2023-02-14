using System;

public class Customer
{
    public string _name = "";
    public List<Address> _address = new List<Address>();

    public List<String> _wLive = new List<string>();

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public Customer(string name)
    {
        _name = name;
    }


    public void VerifyCountry2()
    {
        foreach (Address adss in _address)
        {
            _wLive.Add(adss.VerifyCountry());
        }
    }

    public string GetAddress()
    {
        return _address[0]._list[0];
    }
}