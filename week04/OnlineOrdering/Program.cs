using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address domesticAddress = new Address(
            "410 Pine Street", "Seattle", "Washington", "USA");
        Customer domesticCustomer = new Customer("Jordan Lee", domesticAddress);
        Order domesticOrder = new Order(domesticCustomer);
        domesticOrder.AddProduct(new Product("Travel Mug", "MUG-204", 18.50m, 2));
        domesticOrder.AddProduct(new Product("Notebook", "NOTE-110", 6.25m, 3));
        domesticOrder.AddProduct(new Product("Pen Set", "PEN-018", 4.75m, 1));

        Address internationalAddress = new Address(
            "12 Palm Avenue", "Lagos", "Lagos State", "Nigeria");
        Customer internationalCustomer = new Customer("Ada Okafor", internationalAddress);
        Order internationalOrder = new Order(internationalCustomer);
        internationalOrder.AddProduct(new Product("Desk Lamp", "LAMP-310", 32.00m, 1));
        internationalOrder.AddProduct(new Product("Drawing Pad", "PAD-225", 12.40m, 2));
        internationalOrder.AddProduct(new Product("Marker Set", "MARK-042", 9.99m, 1));

        List<Order> orders = new() { domesticOrder, internationalOrder };

        for (int i = 0; i < orders.Count; i++)
        {
            Console.WriteLine($"ORDER {i + 1}");
            Console.WriteLine("Packing label:");
            Console.WriteLine(orders[i].GetPackingLabel());
            Console.WriteLine("Shipping label:");
            Console.WriteLine(orders[i].GetShippingLabel());
            Console.WriteLine($"Total cost: ${orders[i].GetTotalCost():0.00}");
            Console.WriteLine();
        }
    }
}
