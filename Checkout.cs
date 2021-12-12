using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AseessmentFirstCentral
{
	public class Checkout
	{
		public List<Item> Items = new List<Item>();
		public double Price { get; set; }
		public double Total()
		{
			foreach (Item item in Items)
			{
				foreach (Offer y in Offer.Offers)
				{
					if (y.SKU == item.SKU)
					{
						if (item.Quantity >= y.Quantity)
						{
							int remainder = item.Quantity % y.Quantity;

							if (remainder > 0)
							{
								double floatNumber = item.Quantity / y.Quantity;
								int howManyOfferPrice = (int)(floatNumber - Math.Truncate(floatNumber));

								Price += howManyOfferPrice * y.OfferPrice;
								Price += item.Price * remainder;
							}
							else
							{
								int howManyOfferPrice = item.Quantity / y.Quantity;
								Price += howManyOfferPrice * y.OfferPrice;
							}
						}
						else
						{
							Price += item.Price * item.Quantity;
						}
					}
					else if (Offer.Offers.FindIndex(i => i.SKU == item.SKU) < 0)
					{
						Price += item.Price * item.Quantity;
					}
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

		public string showCart()
		{

			string allOffers = "";

			foreach (Item i in Items)
			{
				allOffers = i.SKU + " is in the cart its Quantity is " + i.Quantity + " normal Price " + i.Price + "/n";
			}

			return allOffers;
		}
	}
}
