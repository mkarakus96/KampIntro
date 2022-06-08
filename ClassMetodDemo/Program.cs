using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.FirstName = "Ali";
            musteri1.Lastname = "Alican";
            musteri1.Id = 123;
            musteri1.City = "Konya";

            Musteri musteri2 = new Musteri();
            musteri2.FirstName = "Veli";
            musteri2.Lastname = "Velican";
            musteri2.Id = 1234;
            musteri2.City = "Nevsehir";

            Musteri musteri3 = new Musteri();
            musteri3.FirstName = "Deli";
            musteri3.Lastname = "Delican";
            musteri3.Id = 12345;
            musteri3.City = "Kocaeli";

            Musteri musteri4 = new Musteri();
            musteri4.FirstName = "Belli";
            musteri4.Lastname = "Bellican";
            musteri4.Id = 123456;
            musteri4.City = "Bursa";

            Musteri[] musteri = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            MusteriManager musteriManager = new MusteriManager();
            foreach (Musteri musteriNo in musteri)
            {
                musteriManager.MusteriEkle(musteriNo);
                musteriManager.MusteriGuncelle(musteriNo);
                musteriManager.MusteriListele(musteriNo);
                musteriManager.MusteriSil(musteriNo);
            }
        }
    }
}
