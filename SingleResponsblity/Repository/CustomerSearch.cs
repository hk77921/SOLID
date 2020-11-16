using SingleResponsblity.Context;
using SingleResponsblity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsblity.Repository
{
    public class CustomerSearch : ICustomerSearch
    {
        private readonly AppDBContext _context;

        public CustomerSearch(AppDBContext context)
        {
            _context = context;
        }

        public List<Customer> SearchByCompanyName(string company)
        {
            var query = from c in _context.Customers
                        where c.CompanyName == company
                        orderby c.CustomerID ascending
                        select c;
            return query.ToList();
        }

        public List<Customer> SearchByContactName(string contact)
        {
            // return _context.Customers.Where(x => x.ContactName.Contains(contact)).ToList();

            var query = from c in _context.Customers
                        where c.ContactName ==contact
                        orderby c.CompanyName ascending
                        select c;
            return query.ToList();
        }

        public List<Customer> SearchByCountry(string country)
        {
            var query = from c in _context.Customers
                        where c.Country == country
                        orderby c.Country ascending
                        select c;

            return query.ToList();
        }
    }
}
