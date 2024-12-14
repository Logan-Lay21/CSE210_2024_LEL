using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Product p11 = new Product("Cheese","D4",5.89m,3);
        Product p12 = new Product("Crackers", "B9", 1.99m, 5);
        Customer c1 = new Customer("Logan Lay", new Address("123 Main St", "Anytown", "NY", "USA"));
        Order o1 = new Order(c1);
        o1.AddItem(p11);
        o1.AddItem(p12);
        Console.WriteLine("Order 1 Total Cost: $" + o1.GetTotalCost());        
        Console.WriteLine("Packing Lable\n================================");
        Console.WriteLine(o1.GetPackingLabel());

        Console.WriteLine("Shipping Label\n================================");
        Console.WriteLine(o1.GetShippingLabel());

        Product p21 = new Product("Potatoes","D7",7.99m,3);
        Product p22 = new Product("Chicken", "F7", 9.50m, 3);
        Customer c2 = new Customer("Logan Lay", new Address("123 Main St", "Anytown", "NY", "USA"));
        Order o2 = new Order(c2);
        o2.AddItem(p21);
        o2.AddItem(p22);
        Console.WriteLine("Order 2 Total Cost: $" + o2.GetTotalCost());        
        Console.WriteLine("Packing Lable\n================================");
        Console.WriteLine(o2.GetPackingLabel());

        Console.WriteLine("Shipping Label\n================================");
        Console.WriteLine(o2.GetShippingLabel());

        Product p31 = new Product("Fries","A2",7.99m,3);
        Product p32 = new Product("Chicken", "F7", 9.50m, 3);
        Product p33 = new Product("Smoothie", "G6", 3.89m, 2);
        Customer c3 = new Customer("Logan Lay", new Address("123 Main St", "Anytown", "NY", "USA"));
        Order o3 = new Order(c3);
        o3.AddItem(p31);
        o3.AddItem(p32);
        o3.AddItem(p33);
        Console.WriteLine("Order 3 Total Cost: $" + o3.GetTotalCost());        
        Console.WriteLine("Packing Lable\n================================");
        Console.WriteLine(o3.GetPackingLabel());

        Console.WriteLine("Shipping Label\n================================");
        Console.WriteLine(o3.GetShippingLabel());

    }
}