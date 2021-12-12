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
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Item(string sku, double price)
        {
            SKU = sku;
            Quantity = 1;
            Price = price;
        }
    }
}
