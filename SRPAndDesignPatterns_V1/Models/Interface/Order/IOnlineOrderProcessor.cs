using SRPAndDesignPatterns_V1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRPAndDesignPatterns_V1.Repository.Order
{
    interface IOnlineOrderProcessor
    {
        bool ValidateCardInfo(CardInfo obj);
    }
}
