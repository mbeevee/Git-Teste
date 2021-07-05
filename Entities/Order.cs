using Curso.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Item = new List<OrderItem>();
        public Client Client { get; set; }
        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void addItem(OrderItem item)
        {
            Item.Add(item);
        }
        public void removeItem(OrderItem item)
        {
            Item.Remove(item);
        }
        public double total()
        {
            double tot = 0;
            foreach (OrderItem item in Item)
            {
                tot += item.subTotal();
            }
            return tot;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY : ");
            sb.AppendLine($"Order moment: {Moment}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client.Name} {Client.BirthDate.ToString("dd/MM/yyyy")} - {Client.Email}");
            sb.AppendLine("Order items: ");
            foreach(OrderItem aux in Item)
            {
                sb.AppendLine(aux.ToString());
            }
            return sb.ToString();

        }
    }
}
