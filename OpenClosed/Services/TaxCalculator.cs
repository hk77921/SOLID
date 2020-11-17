using OpenClosed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClosed.Services
{
    public class TaxCalculator
    {
        public decimal CalculateTax(ITaxCalculator taxCalculator)
        {
            decimal TaxAmount= taxCalculator.CalculateTaxAmount();
            return TaxAmount;
        }
    }
}
