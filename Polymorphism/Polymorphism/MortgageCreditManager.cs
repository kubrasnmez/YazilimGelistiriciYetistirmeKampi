using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class MortgageCreditManager:ICreditManager
    {
        public void Birseyyap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }
       
    }
}
