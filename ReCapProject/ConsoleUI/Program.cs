using Business.Concreate;
using DataAccess.Concreate.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Referans tutucular abstract klasörünün içine konulur.
    
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + "\t" + car.BrandId + "\t" + car.ColorId + "\t" + car.DailyPrice + "\t" + car.ModelYear + "\t" + car.Description);
            }
          
        }
    }
}
