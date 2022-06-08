using System;
using System.Collections.Generic;

namespace MyListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList<string> isimler = new MyList<string>();

            //isimler.Add("Büşra");
            //foreach (var item in isimler.Items)
            //{
            //    Console.WriteLine(item);
            //}
            //isimler.Add("Muhammed");
            //foreach (var item in isimler.Items)
            //{
            //    Console.WriteLine(item);
            //}
            //isimler.Add("Asya Meva");
            //foreach (var item in isimler.Items)
            //{
            //    Console.WriteLine(item);
            //}


            MyDictionary2<int, string> myDictionary = new MyDictionary2<int, string>();
            myDictionary.Add(1,"Adana");
            myDictionary.Add(16,"Bursa");
            myDictionary.Add(42,"Konya");
            myDictionary.Add(50,"Nevşehir");
            myDictionary.Add(27,"Gaziantep");
            myDictionary.Add(41,"Kocaeli");

            Console.WriteLine(myDictionary.ToString());
            myDictionary.Add(1, "Adana");
            myDictionary.Add(16, "Bursa");
            myDictionary.Add(42, "Konya");
            myDictionary.Add(50, "Nevşehir");
            myDictionary.Add(27, "Gaziantep");
            myDictionary.Add(41, "Kocaeli");
            Console.WriteLine(myDictionary.ToString());

        }
    }
}
