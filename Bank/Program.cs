using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalFinanceCreditManager personalFinanceCredit = new PersonalFinanceCreditManager();
            TransportCreditManager transportCredit = new TransportCreditManager();

            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCredit, transportCredit };
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.GiveInfoAboutCredit(credits);
            
        }
    }
}
