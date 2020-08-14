using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRPAndDesignPatterns_V1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Address   ShippingAddress { get; set; }

        public Customer Customer { get; set; }
        public CardInfo CardInfo { get; set; }

        public Order()
        {
            Customer = new Customer();
            CardInfo = new CardInfo();
        }
    }
}
