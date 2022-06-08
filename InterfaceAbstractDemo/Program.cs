using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager();
            customerManager.Save(new Customer {DateOfBirth=new DateTime(1996,2,10),FirstName="Muhammed",LastName="Karakuş",NationalityId="33976486400" });
        }
    }



}
