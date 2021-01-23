using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerçek Müşteri
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "232411";
            musteri1.Adi = "Aydın";
            musteri1.SoyAdi = "AS";
            musteri1.Id = 1;

            // Tüzel Müşteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "24723";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "234824";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}
