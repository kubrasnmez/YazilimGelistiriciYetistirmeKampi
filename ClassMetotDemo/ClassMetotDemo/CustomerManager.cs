using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.TC  + "  kimlik numaralı müşteri eklendi.");
        }
        public void List(Customer customer)
        {
            
                Console.WriteLine("\n**********************");
                Console.WriteLine("Musteri Id :" + customer.Id);
                Console.WriteLine("Musteri Ad : " + customer.Ad);
                Console.WriteLine("Musteri Soyad : {0}", customer.Soyad);
                Console.WriteLine("Musteri TC : {0}", customer.TC);
                Console.WriteLine("Musteri Adres : {0}", customer.Adres);
                Console.WriteLine("Musteri Email : {0}", customer.Email);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("******************************");
            Console.WriteLine(customer.TC  + "  kimlik numaralı müşteri silinmiştir.");

        }
    }
}
