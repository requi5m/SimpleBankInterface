using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCustomerAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomerManager customer1 = new RealCustomerManager();
            customer1.Id = 1;
            customer1.CustomerNo = "1234567890";
            customer1.Name = "Yigit";
            customer1.LastName = "Altınay";

            NonRealCustomer customer2 = new NonRealCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "5492876298";
            customer2.CompanyName = "Company";
            customer2.TaxName = "1947583928";
        }
    }
}
