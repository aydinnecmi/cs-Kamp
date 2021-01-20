using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };

            isimler2.Add("Aydın");
            foreach  (string isim in isimler2) {

                Console.WriteLine(isim);


            }
          

        }
    }
}
