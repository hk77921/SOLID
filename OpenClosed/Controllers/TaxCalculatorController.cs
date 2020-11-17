using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenClosed.Models;
using OpenClosed.Services;

namespace OpenClosed.Controllers
{
    public class TaxCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IncomeDetails obj)
        {
            ITaxCalculator t = null;
            switch (obj.Country)
            {
                case "USA":
                    t = new TaxCalculatorForUS();
                    break;
                case "UK":
                    t = new TaxCalculatorForUK();
                    break;
                case "IN":
                    t = new TaxCalulatorForIN();
                    break;
            }
            t.TotalIncome = obj.TotalIncome;
            t.TotalDeduction = obj.TotalDeduction;
            TaxCalculator cal = new TaxCalculator();
            ViewBag.TotalTax = cal.CalculateTax(t);
            return View("Index", obj);
        }

      

    }
}
