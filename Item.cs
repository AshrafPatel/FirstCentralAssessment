using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AseessmentFirstCentral
{
    public class Item
    {
        public string  SKU { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Item(string sku, int quantity, decimal price)
        {
            SKU = sku;
            Quantity = quantity;
            Price = price;
        }
    }
}
