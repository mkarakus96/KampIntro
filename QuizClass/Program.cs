using System;

namespace QuizClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.CarBrand = "Dacia";
            car1.CarModel = "Logan";
            car1.CarProductYer = 2005;
            car1.CarKm = 143000;
            car1.CarPrice = 120000;

            Car car2 = new Car();
            car2.CarBrand = "Opel";
            car2.CarModel = "Astra";
            car2.CarProductYer = 2015;
            car2.CarKm = 143000;
            car2.CarPrice = 220000;

            Car car3 = new Car();
            car3.CarBrand = "Nissan";
            car3.CarModel = "Primera";
            car3.CarProductYer = 2005;
            car3.CarKm = 153000;
            car3.CarPrice = 130000;

            Car car4 = new Car();
            car4.CarBrand = "Fiat";
            car4.CarModel = "Egea";
            car4.CarProductYer = 2017;
            car4.CarKm = 60000;
            car4.CarPrice = 320000;

            Car car5 = new Car();
            car5.CarBrand = "Dacia";
            car5.CarModel = "Duster";
            car5.CarProductYer = 2022;
            car5.CarKm = 0;
            car5.CarPrice = 420000;

            Car[] car = new Car[] { car1, car2, car3, car4, car5 };

            //foreach
            foreach (Car carProp in car)
            {
                Console.WriteLine(carProp.CarBrand + " " + carProp.CarModel + " : " + carProp.CarPrice + " tl ");
            }


            //for
            //for(int i=0;i<car.Length;i++)
            //{
            //    Console.WriteLine(car[i].CarBrand + " " + car[i].CarModel + " : " + car[i].CarPrice + " tl ");
            //}

            //while
            //bool isComplated = false;
            //int counter = 0;
            //while (!isComplated)
            //{
            //    Console.WriteLine(car[counter].CarBrand + " " + car[counter].CarModel + " : " + car[counter].CarPrice + " tl ");

            //    counter++;
            //    if (counter == car.Length)
            //        isComplated = true;
            //}


            Console.WriteLine("Metotlar -----------------");

            
        }
    }

    class Car
    {
        public string CarBrand { get; set; }

        public string CarModel { get; set; }

        public int CarKm { get; set; }

        public int CarProductYer { get; set; }

        public int CarPrice { get; set; }
    }
}
