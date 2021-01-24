using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class TransportCreditManager:ICreditManager
    {
        public void Birseyyap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }
    }
}
