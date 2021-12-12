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

                //if (Offer.Offers.Any(y =>
                {
                    if (item.Quantity >= y.Quantity)
                    {
                        int remainder = item.Quantity % y.Quantity;

                        if (remainder > 0)
                        {
                            decimal floatNumber = item.Quantity / y.Quantity;
                            int howManyOfferPrice = (int)(floatNumber - Math.Truncate(floatNumber));

                            Price += howManyOfferPrice * y.Price;
                            Price += item.Price * remainder;
                        }
                        else
                        {
                            int howManyOfferPrice = item.Quantity / y.Quantity;
                            Price += howManyOfferPrice * y.Price;
                        }
                    }
                    else
                    {
                        Price += item.Price * item.Quantity;
                    }
                } 
                else
                {
                    Price += item.Price * item.Quantity;
                }
            }

            return Price;
        }
        public void Scan(Item item)
        {
            foreach (Item i in Items)
            {
                if (i.SKU == item.SKU)
                {
                    i.Quantity += 1;
                    return;
                }
            }

            Items.Add(item);
        }
    }
}
