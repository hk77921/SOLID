using SingleResponsblity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsblity.Repository
{
    public class ExportData : IExportData
    {
        public string ExportToCSV(List<Customer> customers)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var customer in customers)
            {
                sb.AppendFormat("{0},{1},{2},{3}", customer.CustomerID, customer.CompanyName, customer.ContactName, customer.Country);
                sb.AppendLine();
                sb.Append("----------------------------------");
                sb.AppendLine();
            }
            return sb.ToString();
        }


       
        public string ExportToPDF(List<Customer> customers)
        {
            throw new NotImplementedException();
        }

        public string ExportToXML(List<Customer> customers)
        {
            throw new NotImplementedException();
        }
    }
}
