using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class RequirementCreditManager:ICreditManager
    {
        public void Birseyyap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }
    }
}
