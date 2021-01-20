using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.Surname + " " + "Sisteme Eklendi!");

        }

        public void MusteriSil(Musteri musteri)
        {

            Console.WriteLine(musteri.Name + " " + musteri.Surname + " " + "Sistemden silindi!");
        }

        

        public void MusteriListele(Musteri[] musteriler)
        {

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Name);
                Console.WriteLine(musteri.Surname);
                Console.WriteLine(musteri.PhoneNumber);
               

            }
        }

       
    }
}
