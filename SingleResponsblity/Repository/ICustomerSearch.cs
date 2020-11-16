using SingleResponsblity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleResponsblity.Repository
{
    public interface ICustomerSearch
    {
        List<Customer> SearchByCountry(string country);

        List<Customer> SearchByCompanyName(string company);
        List<Customer> SearchByContactName(string contact);
        

    }
}
