using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    interface ICreditManager
    {
        //imzanın aynı olduğu ama içerisinin farklı olduğu durumlarda interface olarak oluştururuz.
        //miras alanlar içerisineki tüm metodları içermek zorundadır.
        //interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlarda kullanırız.
        void Calculate();
        void Birseyyap();

       
    }
}
