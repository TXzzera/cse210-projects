using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("356 Paulista Avenue", "São Paulo", "SP", "Brazil");
        Address address2 = new Address("581 Wood St", "Price", "Utah", "USA");

        Customer customer1 = new Customer("Daniel Clark", address1);
        Customer customer2 = new Customer("Lisa Simpson", address2);

        Product product1 = new Product("Black Shirt", "A001", 09.99, 3);
        Product product2 = new Product("Red Cap", "B003", 25.49, 2);
        Product product3 = new Product("White Skirt", "C002", 13.49, 3);
        Product product4 = new Product("Blue T-Shirt", "A004", 10.19, 2);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        order1.AddProduct(product1);
        order1.AddProduct(product3);
        order2.AddProduct(product2);
        order2.AddProduct(product4);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: ${order1.TotalPriceOrder(customer1.LiveInUsa())}\n");
        
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: ${order2.TotalPriceOrder(customer2.LiveInUsa())}\n");
        


    }
}