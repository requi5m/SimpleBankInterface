using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class ApplicationManager
    {
        public void GiveInfoAboutCredit(List<ICreditManager> credit)
        {
            foreach (var credits in credit)
            {
                credits.Calculate();
                
            }
        }
    }
}
