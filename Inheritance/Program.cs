using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[2]
            {
               new Customer(), new Student()
            };
            
        }
    }

    class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Depertmant { get; set; }
    }
}
