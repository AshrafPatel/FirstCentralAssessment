using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace AseessmentFirstCentral
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREATING ITEMS
            Item item1 = new Item("A99", 0.50);
            Item item2 = new Item("B15", 0.30);
            Item item3 = new Item("C40", 0.60);

            //CREATING OFFERS
            Offer o1 = new Offer("A99", 3, 1.30);
            Offer o2 = new Offer("B15", 2, 0.45);

            //ADD OFFERS
            Offer.Offers.Add(o1);
            Offer.Offers.Add(o2);
            Offer.ShowOffers();

            //SCAN ITEMS
            Checkout checkout = new Checkout();
            checkout.Scan(item1);
            checkout.Scan(item2);
            checkout.Scan(item2);

            //TOTAL
            Console.WriteLine(checkout.showCart());
            Console.WriteLine(checkout.Total());
        }
    }
}
