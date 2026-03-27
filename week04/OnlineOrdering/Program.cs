using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 International
        Address addr1 = new Address("Calle Macedonio Alcalá", "Oaxaca City", "Oaxaca", "Mexico");
        Customer cust1 = new Customer("Miguel Rivera", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Leather Huaraches", "SH-001", 45.00, 1));
        order1.AddProduct(new Product("Alebrije Sculpture", "ART-452", 120.50, 2));
        //Order 2 in Usa
        Address addr2 = new Address("street Marylin Monroe", "New York", "New York", "USA");
        Customer cust2 = new Customer("Joe Biden", addr2);
        Order order2  = new Order(cust2);
        order2.AddProduct(new Product("Leather jacket", "SH-021", 45.00, 1));
        order2.AddProduct(new Product("Smartwatch", "ART-455", 120.50, 2));
        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");
        Console.WriteLine("----------------------------\n");

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}\n");
        Console.WriteLine("----------------------------\n");

    }
}   