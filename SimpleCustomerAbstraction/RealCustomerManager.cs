using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCustomerAbstraction
{
    class RealCustomerManager:Customer
    {        
        public string Name { get; set; }
        public string LastName { get; set; }       
    }
}
