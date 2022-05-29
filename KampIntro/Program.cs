using System;

namespace KampIntro
{
    class Program
    {

        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 86;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursEgitmeni = "Kerem";
            kurs2.IzlenmeOrani = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursEgitmeni = "Berkay";
            kurs3.IzlenmeOrani = 30;


            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var item in kurslar)
            {
                Console.WriteLine(item.KursEgitmeni);

            }

            //   Console.WriteLine(kurs1.KursEgitmeni + " " + kurs1.KursAdi);


            Console.WriteLine("Metotlar -----------------");


           
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
