using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri
            {
                Id = 1,
                Name = "Aydın",
                Surname = "Mehmet",
                PhoneNumber = 320491341
            };


            Musteri musteri2 = new Musteri
            {
                Id = 2,
                Name = "ahmet",
                Surname = "deli",
                PhoneNumber = 3242352
            };


            Musteri musteri3 = new Musteri
            {
                Id = 3,
                Name = "necati",
                Surname = "şaşmaz",
                PhoneNumber = 456456363
            };


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            //musteriManager.MusteriEkle(musteri1);
            //musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriSil(musteri3);
            //musteriManager.MusteriListele(musteriler);
           


        }
    }
}
