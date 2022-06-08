using System;

namespace Vid_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager();
            //ProductManager productManager = new ProductManager();
            //customerManager.Add();
            //customerManager.Update();
            //productManager.Add();
            //productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.FirstName = "Muhammed";
            customer.LastName = "Karakus";
            customer.Id = 2;

            Console.WriteLine(customer.FirstName);

            Console.ReadLine();
        }
    }

}
