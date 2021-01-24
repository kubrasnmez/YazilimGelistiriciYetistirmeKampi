using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfacelerde, o interfacei implemente eden classın referans numarasını tutabilir.

            ICreditManager requirementCreditManager = new RequirementCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            ILoggerService fileloggerservice = new FileLoggerService();
            ILoggerService databaseloggerservice = new DatabaseLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.BasvuruYap(requirementCreditManager,new List<ILoggerService> {new DatabaseLoggerService(), new FileLoggerService()});

            List<ICreditManager> credits = new List<ICreditManager>() {requirementCreditManager,transportCreditManager };
            //applicationManager.CreditPreInformation(credits);


            

        }
    }
}
