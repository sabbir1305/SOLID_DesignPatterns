using SRPAndDesignPatterns_V1.Models;
using SRPAndDesignPatterns_V1.Repository.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRPAndDesignPatterns_V1.Repository
{
    public class OnlineOrderProcessor : IOrderProcessor, IOnlineOrderProcessor
    {
        public void ProcessOrder(Models.Order order)
        {
           //Do 
        }

        public bool ValidateCardInfo(CardInfo obj)
        {
            return true;
        }

        public bool ValidateShippingAddress(Address obj)
        {
            return true;
        }
    }
}
