using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class ApplicationManager
    {
        //Method injection
        public void BasvuruYap(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            /*
             * Parametresiz halinde
             * Tüm başvurular konut kredisi üzerinden hesaplanır. - Yanlış
            MortgageCreditManager mortgageCreditManager = new MortgageCreditManager();
            mortgageCreditManager.Calculate();
            */
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void CreditPreInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
