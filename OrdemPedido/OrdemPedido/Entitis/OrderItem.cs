using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace OrdemPedido.Entitis
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quality, double price, Product product)
        {
            Quantity = quality;
            Price = price;
            Product = product;
        }


        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture) + ", Quantity: "
            + Quantity
            + ", Subtotal: "
            + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}