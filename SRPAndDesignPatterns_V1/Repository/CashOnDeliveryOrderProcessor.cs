using SRPAndDesignPatterns_V1.Models;
using SRPAndDesignPatterns_V1.Repository.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRPAndDesignPatterns_V1.Repository
{
    public class CashOnDeliveryOrderProcessor : IOrderProcessor
    {
        public void ProcessOrder(Models.Order order)
        {
            //do
        }

        public bool ValidateShippingAddress(Address obj)
        {
            return true;
        }
    }
}
