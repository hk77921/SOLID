using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SingleResponsblity.Models;
using SingleResponsblity.Repository;

namespace SingleResponsblity.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerSearch _customerSearch;
        private readonly IExportData _exportData;

        public CustomerController(ICustomerSearch customerSearch,IExportData exportData)
        {
            _customerSearch = customerSearch;
            _exportData = exportData;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            return View();
        }


        public List<Customer> GetData(string SearchCriteria, string SearchBy)
        {
            List<Customer> _customer = null;

            switch (SearchBy)
            {
                case "companyname":
                    _customer = _customerSearch.SearchByCompanyName(SearchCriteria);
                    break;
                case "contactname":
                    _customer = _customerSearch.SearchByContactName(SearchCriteria);
                    break;
                case "country":
                    _customer = _customerSearch.SearchByCountry(SearchCriteria);
                    break;
            }

            return _customer;
        }
        [HttpPost]
        public IActionResult Search(string criteria, string searchBy)
        {
            List<Customer> customers = GetData(criteria, searchBy);
            ViewBag.Criteria = criteria;
            ViewBag.SearchBy = searchBy;

            return View(customers);
        }
        [HttpPost]
        public FileResult Export(string criteria, string searchBy)
        {
            List<Customer> data = GetData(criteria, searchBy);

            string exportdata = _exportData.ExportToCSV(data);

            return File(System.Text.ASCIIEncoding.ASCII.GetBytes(exportdata),"application/Excel",searchBy);

        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
