using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Curso.Entities.Enums;
using Curso.Entities;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string email;
            DateTime birth;
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Email: ");
            email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            birth = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birth);
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());
            Order order = new Order(DateTime.Now, os, client);
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEnter #{i} item data: ");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(prodName, prodPrice);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem oi = new OrderItem(quantity, prodPrice, product);
                order.addItem(oi);
            }
            Console.WriteLine("\n",order);
        }
    }
}
