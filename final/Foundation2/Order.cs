using System;
public class Order
{
    private List<Product> _products;
    public Customer _customer { get; private set; }
    private double _cost;

    public Order()
    {
        _products = new List<Product>();
        _customer = new Customer("");
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void CalculateTotalPrice()
    {
        _cost = 0;
        Console.WriteLine("_____Total Price______");
        foreach (Product product in _products)
        {
            double price = product.GetPrice();
            _cost += price;
        }

        if (_customer._address != null && _customer._address.IsUSA())
        {
            _cost += 5;
            Console.WriteLine("Your Shipping is: $5");
        }
        else
        {
            _cost += 35;
            Console.WriteLine("Your Shipping is: $35");
        }

        Console.WriteLine();
        Console.WriteLine($"Total Price: {_cost}");
        Console.WriteLine();
    }

    public void GetPackingLabel()
    {
        Console.WriteLine();
        Console.WriteLine("_____________________");
        Console.WriteLine("----Packing Label----");
        int i = 1;

        foreach (Product product in _products)
        {
            Console.WriteLine($"{i}. {product.GetProductInfo()}");
            i++;
        }

        Console.WriteLine();
        Console.WriteLine($"Total Cost: {_cost}");
        Console.WriteLine();
        Console.WriteLine("_____________________");
    }

    public void GetShippingLabel()
{
    Console.WriteLine();
    Console.WriteLine("_____________________");
    Console.WriteLine("----Shipping Label----");
    Console.WriteLine(_customer._name);
    if (_customer._address != null)
    {
        _customer._address.DisplayAddress();
    }
    Console.WriteLine();
    Console.WriteLine("_____________________");
}
}