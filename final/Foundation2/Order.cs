using System;

public class Order
{
    public List<Product> _productList = new List<Product>();

    public List<Customer> _customer = new List<Customer>();

    
    public void GetTotalPrice()
    {
        float totalPrice;
        foreach (Customer c in _customer)
        {
                float totalProPrice = 0;
                int i = 0;
                while (i < _productList.Count())
                {
                    totalProPrice = totalProPrice + _productList[i].GetPrice();
                    i++;
                }

                if (c._wLive[0] == "In the USA")
                {
                    totalPrice = totalProPrice + 5;
                }
                else 
                {
                    totalPrice = totalProPrice + 35;
                }
            Console.WriteLine($"Total price: ${totalPrice}");
        }
    }

    public void Packing()
    {
        foreach (Product pro in _productList)
        {
            Console.WriteLine($"Name of product: {pro._name}, id: {pro._id}");
        }
    }

    public void Chipping()
    {
        Console.WriteLine(_customer[0]._name);
        Console.WriteLine(_customer[0].GetAddress());
    }
}