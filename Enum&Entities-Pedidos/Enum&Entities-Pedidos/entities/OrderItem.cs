

namespace Enum_Entities_Pedidos.Entities
{
    public class OrderItem
    {
        public int Quantity { get; private set; }
        public double Price { get; private set; }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
