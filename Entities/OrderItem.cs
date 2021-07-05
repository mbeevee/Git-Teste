using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product  Product { get; set; }
        public double subTotal()
        {
            return Quantity * Price;
        }
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        public override string ToString()
        {
            return $"{Product}, ${Price.ToString("F2")}, Quantity:{Quantity}, Subtotal: ${(Quantity * Price).ToString("F2")}";
        }
    }
}
