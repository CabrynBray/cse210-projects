public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer = new Customer("");
    private double _cost;

    public Order()
    {
       // _products = new List<Product>();
    }
    public List<Product> GetProducts()
    {
        return _products;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public void CalculateTotalPrice()
    {
        _cost = 0;
        Console.WriteLine("_____Totlal Price______");
        foreach(Product product in _products)
        {
            double price = product.GetPrice();
            _cost = _cost + price;
        }
        if (_customer.IsUSA() == true)
        {
            _cost = _cost + 5;
            Console.WriteLine("Your Shipping is: $5");
        }
        else if (_customer.IsUSA() == false)
        {
            _cost = _cost + 35;
            Console.WriteLine("Your Shipping is: $35");
        }
        Console.WriteLine();
        Console.WriteLine($"Total Price: {_cost}");
        Console.WriteLine();
    }
    public void GetPackingLable()
    {
        Console.WriteLine();
        Console.WriteLine("_____________________");
        Console.WriteLine("----Packing Lable----");
        int i = 1;
        foreach(Product product in _products)
        {
            Console.WriteLine($"{i}. {product.productInfo()}");
            i = i + 1; 
        }
        Console.WriteLine();
        Console.WriteLine($"{_cost}");
        Console.WriteLine();
        Console.WriteLine("_____________________");
    }
    public void GetShippingLabel()
    {
        Console.WriteLine();
        Console.WriteLine("_____________________");
        Console.WriteLine("----Shipping Label----");
        
        Console.WriteLine($"{_customer.GetName()}");
        Console.WriteLine($"{_customer.GetAddress().DisplayAddress()}");

        Console.WriteLine();
        Console.WriteLine("_____________________");
    }
}