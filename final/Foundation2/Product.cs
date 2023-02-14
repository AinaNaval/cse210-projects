using System;

public class Product
{
    public string _name = "";
    public int _id;
    private int _quantity;
    private float _price;

    public Product(string name, int id, int quantity, float price)
    {
        _name = name;
        _id = id;
        _quantity = quantity;
        _price = price;
    }

    public float GetPrice()
    {
        float allPrice = _price * _quantity;
        return allPrice;
    }
}