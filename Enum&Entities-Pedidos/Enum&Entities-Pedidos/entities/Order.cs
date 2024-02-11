
using Enum_Entities_Pedidos.entities;
using Enum_Entities_Pedidos.entities.@enum;


namespace Enum_Entities_Pedidos.Entities
{
    public class Order
    {
       private OrderStatus _status { get; }
      public DateTime Moment {  get; private set; }

        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();

        public Client Client { get; private set; }

        public Order( DateTime moment, Client client)
        {
            _status = OrderStatus.PendingPayment;
            Moment = moment;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item) {  Items.Remove(item); }

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
