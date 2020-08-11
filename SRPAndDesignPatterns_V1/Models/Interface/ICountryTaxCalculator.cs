using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRPAndDesignPatterns_V1.Models.Interface
{
   public interface ICountryTaxCalculator
    {
        decimal TotalIncome { get; set; }
        decimal TotalDeduction { get; set; }
        decimal CalculateTaxAmount();
    }
}
