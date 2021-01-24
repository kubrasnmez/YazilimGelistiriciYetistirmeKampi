using System;

namespace RefOut
{
    class Program
    {
        
        static void Main(string[] args)
        {

            /*
            Ref ve out değer tiplerinin referans tip gibi kullanılmasını sağlar. Percent değişkeni bellekte kullanılan adrese gönderilir.
            Ref-out kullanarak adresi alıyoruz. 
            Method tanımlanırken değişkenin önüne ref veya out yazılmalıdır.
            Ref ve out'un kullanım amacı aynıdır. Sadece aralarındaki fark ref kullanıldığında ilk değer ataması yapılması zorunludur.
            */

            int total_amount = 3000;
            Console.WriteLine("Total Amount : " + total_amount);
            int percent = 0;
            int selection;
            Console.WriteLine("Please select the discount rate to be applied \n 1 : Student \n 2 : Retired \n 3 : Elderly");
            selection = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    var result_student = Student(total_amount, ref percent);
                    Console.WriteLine("Total amount after the discount to be applied : {0} ", result_student);
                    Console.WriteLine("Percent amount applied : {0}  ", percent);
                    break;

                case 2:
                    var result_retired = Retired(total_amount, ref percent);
                    Console.WriteLine("Total amount after the discount to be applied : {0} ",result_retired);
                    Console.WriteLine("Percent amount applied : {0}  ",percent);
                    break;

                case 3:
                    var result_elderly = Elderly (total_amount, ref percent);
                    Console.WriteLine("Total amount after the discount to be applied : {0}",result_elderly);
                    Console.WriteLine("Percent amount applied : {0}  ",percent);
                    break;
                default:
                    Console.WriteLine("Please make a valid selection.");
                    break;

            }
        }
        static int Student(int total_amount,ref int percent)
        {
            percent = 20;
            int result = total_amount - (total_amount * percent / 100);
            return result;
        }
        static int Retired(int total_amount, ref int percent)
        {
            percent = 10;
            int result = total_amount - (total_amount * percent / 100);
            return result;
        }
        static int Elderly(int total_amount, ref int percent)
        {
            percent = 30;
            int result = total_amount - (total_amount * percent / 100);
            return result;
        }
    }
}
