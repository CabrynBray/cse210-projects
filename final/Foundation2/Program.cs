using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Order oredr1 = new Order();
        
        Address address1 = new Address("30 struben ave", "JHB", "Gauteng", "South Africa");
        Product product1 = new Product("Still spring water", 012345, 4, 50);
        Product product2 = new Product("Tissue box", 678910, 1, 75);
        Product product3 = new Product("Chocolate", 111213, 8, 5);
        Product product4 = new Product("Biltong", 141516, 3, 100);

        orders.Add(oredr1);
        oredr1.AddProduct(product1);
        oredr1.AddProduct(product2);
        oredr1.AddProduct(product3);
        oredr1.AddProduct(product4);
        
        foreach (Order order in orders)
        {
            Console.WriteLine();
            Console.WriteLine($"Customer Name: ");
            Console.WriteLine();
            order.GetPackingLable();
            order.GetShippingLabel();
            Console.WriteLine();
        }
        

    }
}