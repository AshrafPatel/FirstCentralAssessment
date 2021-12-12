using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AseessmentFirstCentral
{
    class Offer
    {
        public static List<Offer> Offers = new List<Offer>();
        public string SKU { get; set; }
        public int Quantity { get; set; }
        public double OfferPrice { get; set; }

        public Offer(string sku, int quantity, double price)
        {
            SKU = sku;
            Quantity = quantity;
            OfferPrice = price;
        }

        public static string ShowOffers()
        {
            string allOffers = "";

            foreach (Offer o in Offers)
            {
                allOffers = "Offer on " + o.SKU + " buy " + o.Quantity + " for only " + o.OfferPrice + "/n";
            }

            return allOffers;
        } 
    }
}
