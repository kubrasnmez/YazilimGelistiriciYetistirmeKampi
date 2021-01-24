using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}
