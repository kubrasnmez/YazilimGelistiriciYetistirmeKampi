using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            char devam;
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            CustomerManager customerManager = new CustomerManager();

            customer1.Id = 0001;
            customer1.Ad = "Ebru";
            customer1.Soyad = "Karasu";
            customer1.TC = "987456321";
            customer1.Email = "ebrukarasu@gmail.com";
            customer1.Adres = "İstanbul";



            customer2.Id = 0002;
            customer2.Ad = "Salih Ahmet";
            customer2.Soyad = "Maral";
            customer2.TC = "258741369";
            customer2.Email = "ebrukarasu@gmail.com";
            customer2.Adres = "Tekirdag";


            customer3.Id = 0003;
            customer3.Ad = "Özge";
            customer3.Soyad = "İrten";
            customer3.TC = "123456789";
            customer3.Email = "ozgeirten@gmail.com";
            customer3.Adres = "İstanbul";

            do
            {
                int secim;
                Console.WriteLine("Lütfen Seçim Yapınız (1,2,3) \n 1 - Müşteri Ekle \n 2 - Müşteri Güncelle \n 3 - Müşteri Silme");
                secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        customerManager.Add(customer1);
                        customerManager.Add(customer2);
                        customerManager.Add(customer3);
                        break;
                    case 2:
                        foreach (var customer in customers)
                        {
                            customerManager.List(customer);
                        }
                        break;
                    case 3:
                        customerManager.Delete(customer1);
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim yaptınız.");
                        break;

                }
                Console.WriteLine("Devam etmek ister misiniz (E/H)");
                devam = Convert.ToChar(Console.ReadLine());
            }
            while (devam == 'E' || devam == 'e');

        }
    }
}
