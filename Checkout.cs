using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AseessmentFirstCentral
{
    public class Checkout
    {
        public List<Item> Items { get; set; }
        public decimal Price { get; set; }
        public decimal Total()
        {
            foreach (Item item in Items)
            {
                Item y;

                if (Offer.Offers.Any(y => y.SKU == item.SKU)) 
                {
                    if (item.Quantity >= y.Quantity)
                }
            }
        }
        public void Scan(Item item)
        {
            Items.Add(item);
        }
    }
}
