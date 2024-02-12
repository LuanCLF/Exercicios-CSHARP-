

namespace Enum_Entities_Pedidos.Entities
{
    public class OrderItem
    {
        public int Quantity { get; private set; }
        public double Price { get; private set; }

        public Product Product { get; private set; }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
