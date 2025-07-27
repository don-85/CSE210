using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "L001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "M101", 25.50, 2));

        Address address2 = new Address("42 Kingsway", "London", "London", "UK");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P202", 799.99, 1));
        order2.AddProduct(new Product("Charger", "C303", 19.99, 2));

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Order 1 Total Cost: ${order1.GetTotalCost()}\n");

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Order 2 Total Cost: ${order2.GetTotalCost()}");
    }
}
