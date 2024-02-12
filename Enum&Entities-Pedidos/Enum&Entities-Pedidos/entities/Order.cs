
using Enum_Entities_Pedidos.entities;
using Enum_Entities_Pedidos.entities.@enum;
using System.Text;


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

        public override string ToString()
        {
            double total = 0.0;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Order Status: {_status}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
            sb.AppendLine("Order items: ");
            foreach(OrderItem item in Items)
            {
                double subTotal = item.SubTotal();
                total+= subTotal;

                sb.AppendLine($"{item.Product.Name}, ${item.Price:F2}, Quantity: {item.Quantity}, Subtotal: ${subTotal:F2}");
            }

            sb.AppendLine($"Total price: ${total:F2}");

            return sb.ToString();
        
        }

    }
}
