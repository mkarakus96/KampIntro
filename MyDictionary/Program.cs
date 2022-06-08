using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {

        
        static void Main(string[] args)
        {
            


            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            myDictionary.Add("Adana", 1);
            myDictionary.Add("Bursa", 16);
            myDictionary.Add("Konya", 42);
            myDictionary.Add("Nevşehir",50);
            myDictionary.Add("Gaziantep",27);
            myDictionary.Add("Kocaeli", 41);


            foreach (var item in myDictionary)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}
