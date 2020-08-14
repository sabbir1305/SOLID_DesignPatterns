using SRPAndDesignPatterns_V1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRPAndDesignPatterns_V1.Repository.Order
{
    interface IOrderProcessor
    {
        bool ValidateShippingAddress(Address obj);
        void ProcessOrder(SRPAndDesignPatterns_V1.Models.Order order);
    }
}
