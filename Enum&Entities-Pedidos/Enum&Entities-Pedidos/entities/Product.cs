﻿

namespace Enum_Entities_Pedidos.Entities
{
    public class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
