
using Enum_Entities_Pedidos.entities;
using Enum_Entities_Pedidos.entities.@enum;


namespace Enum_Entities_Pedidos.Entities
{
    public class Order(OrderStatus status, DateTime moment, Client client)
    {
        private OrderStatus _status { get; } = status;
        public DateTime Moment { get; private set; } = moment;

        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();

        public Client Client { get; private set; } = client;

        public void AddItem(OrderItem item) => Items.Add(item);
       

        public void RemoveItem(OrderItem item) => Items.Remove(item); 

        public double Total() {
            double sum = 0;

            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;

        }
    }
}
