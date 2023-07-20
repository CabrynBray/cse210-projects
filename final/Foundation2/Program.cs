using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some products
        Product product1 = new Product("Still spring water", 012345, 4, 50);
        Product product2 = new Product("Tissue box", 678910, 1, 75);
        Product product3 = new Product("Chocolate", 111213, 8, 5);
        Product product4 = new Product("Biltong", 141516, 3, 100);
        Product product5 = new Product("Whiskey", 171819, 1, 100);
        Product product6 = new Product("Glasses", 202122, 2, 75);
        Product product7 = new Product("Ice-cream", 232425, 4, 25);
        Product product8 = new Product("Chips", 262728, 3, 18);

        // Create an order
        Order order1 = new Order();
        Order order2 = new Order();

        // Create a customer and set their name
        Customer customer1 = new Customer("John Doe");
        Customer customer2 = new Customer("Jane Smith");

        // Create an address
        Address address1 = new Address("30 struben ave", "JHB", "Gauteng", "South Africa");
        Address address2 = new Address("345 Main Ave", "LA", "CA", "USA");

        // Assign the address to the customer
        customer1.SetAddress(address1);
        customer2.SetAddress(address2);

        // Set the customer for the order
        order1.SetCustomer(customer1);
        order2.SetCustomer(customer2);
        
        // orders.Add(order1);
        // Add products to the order
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        order1.AddProduct(product4);

        order2.AddProduct(product5);
        order2.AddProduct(product6);
        order2.AddProduct(product7);
        order2.AddProduct(product8);

        // Calculate total price
        order1.CalculateTotalPrice();
        // Get packing label
        order1.GetPackingLabel();
        // Get shipping label
        order1.GetShippingLabel();


        // Calculate total price
        order2.CalculateTotalPrice();
        // Get packing label
        order2.GetPackingLabel();
        // Get shipping label
        order2.GetShippingLabel();

    }
        

    }