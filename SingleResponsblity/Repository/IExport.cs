using SingleResponsblity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleResponsblity.Repository
{
   public interface IExportData
    {
        public string ExportToCSV(List<Customer> customers);
        public string ExportToPDF(List<Customer> customers);
        public string ExportToXML(List<Customer> customers);

    }
}
