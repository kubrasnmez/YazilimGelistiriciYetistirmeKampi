using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Sehir = new Dictionary<int, string>();
            int no;
            string isim;
            char devam;
            char ekleme;
            do
            {
                int secim;
                Console.Write("1. Ekleme \n2. Plaka Numarasına Göre Listele \n3. Şehre Göre Listele \nLüfen seçim yapınız(1,2,3) : ");
                secim = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (secim)
                {
                    case 1:
                        do
                        { 
                            Console.WriteLine("*************EKLEME*************");
                            Console.Write("Plaka no : ");
                            no = int.Parse(Console.ReadLine());
                            Console.Write("Şehir : ");
                            isim = Console.ReadLine();
                            Sehir.Add(no, isim);
                            Console.Write("Ekleme yapmaya devam etmek istiyor musunuz? (E/H) ");
                            ekleme = Convert.ToChar(Console.ReadLine());
                            Console.WriteLine();
                        }
                        while (ekleme == 'E' || ekleme == 'e') ;
                        break;
                    case 2:
                        Console.WriteLine("***********PLAKA NUMARASINA GÖRE LİSTELEME***********");
                        Dictionary<int, string>.KeyCollection Anahtar = Sehir.Keys;
                        foreach (int anahtar in Anahtar)
                        {
                            Console.WriteLine(anahtar);
                        }
                        break;
                    case 3:
                        Console.WriteLine("***********ŞEHRE GÖRE LİSTELEME***********");
                        Dictionary<int, string>.ValueCollection Deger = Sehir.Values;
                        foreach (string deger in Deger)
                        {
                            Console.WriteLine(deger);
                        }
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim yaptınız. (1,2 veya 3 rakamlarından birini seçmelisiniz.)");
                        break;
                }
                Console.Write("Devam etmek ister misiniz ? (E/H) ");
                devam = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
            }
            while (devam == 'E' || devam == 'e');

        }
    }
}
