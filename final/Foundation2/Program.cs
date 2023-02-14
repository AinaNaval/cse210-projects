using System;

class Program
{
    static void Main(string[] args)
    {
        
        Order order1 = new Order();
        Customer customer1 = new Customer("Aina Naval");
        Address address1 = new Address("Verrerie", "Tamatave", "Atsinanana", "Madagascar");
        Product product1 = new Product("Smartphone", 034587, 2, 10);
        Product product2 = new Product("PC", 235003, 1, 15);
        
        order1._productList.Add(product1);
        order1._productList.Add(product2);
        order1._customer.Add(customer1);
        customer1._address.Add(address1);
        customer1.VerifyCountry2();
        address1.AllInfo();
        order1.Packing();
        order1.Chipping();
        order1.GetTotalPrice();


        Order order2 = new Order();
        Customer customer2 = new Customer("James Brown");
        Address address2 = new Address("...", "...", "...", "USA");
        Product product3 = new Product("Helmet", 130845, 3, 20);
        Product product4 = new Product("Fan", 450038, 3, 50);

        order2._productList.Add(product3);
        order2._productList.Add(product4);
        order2._customer.Add(customer2);
        customer2._address.Add(address2);
        customer2.VerifyCountry2();
        address2.AllInfo();
        order2.Packing();
        order2.Chipping();
        order2.GetTotalPrice();
    }
}