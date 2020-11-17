using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClosed.Models
{
    public class TaxCalulatorForIN : ITaxCalculator
    {
        public decimal TotalIncome { get ; set; }
        public decimal TotalDeduction { get ; set ; }

        public decimal CalculateTaxAmount()
        {
            decimal TaxableIncome = TotalIncome - TotalDeduction;
            
            return TaxableIncome * 20 / 100;
        }
    }
}
