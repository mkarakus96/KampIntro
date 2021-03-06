using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            // interfaceler de implemente olduğu class'ın referansını alabilir.

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            IKrediManager tasitKrediManager = new TasitKrediManager();

            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();

            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(tasitKrediManager,fileLoggerService);


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, konutKrediManager, tasitKrediManager };
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
