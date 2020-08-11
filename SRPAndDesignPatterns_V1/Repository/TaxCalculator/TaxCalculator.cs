using SRPAndDesignPatterns_V1.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRPAndDesignPatterns_V1.Repository.TaxCalculator
{
    public class TaxCalculator
    {
        public decimal Calculate(ICountryTaxCalculator obj)
        {
            decimal taxAmount = obj.CalculateTaxAmount();
            //do something more if needed
            return taxAmount;
        }
    }
}
