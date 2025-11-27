using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address(
            "123 Main Street",
            "Salt Lake City",
            "UT",
            "USA");

        Address koreaAddress = new Address(
            "456 Guil-ro",
            "Seoul",
            "Seoul",
            "Korea");

        Customer customer1 = new Customer("Gilyeon Hwang", usaAddress);
        Customer customer2 = new Customer("Heewoong Kim", koreaAddress);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "A001", 3.50, 4));
        order1.AddProduct(new Product("Pink Pen", "B002", 1.20, 3));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Mechanical Keyboard", "K100", 80.00, 1));
        order2.AddProduct(new Product("Mouse Pad", "M200", 15.00, 2));
        order2.AddProduct(new Product("USB-C Cable", "C300", 7.50, 3));

        List<Order> orders = new List<Order> { order1, order2 };

        int orderNumber = 1;

        foreach (Order order in orders)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine($"Order #{orderNumber}");
            Console.WriteLine();

            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();

            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();

            Console.WriteLine($"Total Price: ${order.GetTotalCost():0.00}");
            Console.WriteLine();

            orderNumber++;
        }
    }
}
