﻿using Enum_Entities_Pedidos.entities;
using Enum_Entities_Pedidos.entities.@enum;
using Enum_Entities_Pedidos.Entities;
using System.Diagnostics.Metrics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Emter the client data: ");

        Console.Write("Name: ");
        string name = Console.ReadLine()!;

        Console.Write("Email: ");
        string email = Console.ReadLine()!;

        Console.Write("Birth date (DD/MM/YYYY): ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine()!);

        Client  client = new Client(name, email, birthDate);

        Console.WriteLine("Enter the order data: ");

        Console.Write("Status: ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine()!);

        Console.Write("How many items to this order? ");
        int quantity = int.Parse(Console.ReadLine()!);

        Order order = new Order(status, DateTime.Now, client);

        for (int i = 1; i <= quantity; i++)
        {
            Console.WriteLine($"Enter #{i} item data: ");

            Console.Write("Product name: ");
            string productName = Console.ReadLine()!;

            Console.Write("Product price: ");
            double productPrice = double.Parse(Console.ReadLine()!);

            Console.Write("Quantity: ");
            int productQuantity = int.Parse(Console.ReadLine()!);

            Product product = new Product(productName, productPrice);
            OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);
            
            order.AddItem(orderItem);
        }

        Console.WriteLine(order);
    }

   
}