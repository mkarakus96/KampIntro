using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager
    {
        public  void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.FirstName+" "+ musteri.Lastname+" "+ "Musteri Eklendi");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.FirstName + " " + musteri.Lastname + " " + "Musteri Silindi");
        }
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine(musteri.FirstName + " " + musteri.Lastname + " " + "Musteri Listelendi");
        }
        public void MusteriGuncelle(Musteri musteri)
        {
            Console.WriteLine(musteri.FirstName + " " + musteri.Lastname + " " + "Musteri Guncellendi");
        }

    }
}
