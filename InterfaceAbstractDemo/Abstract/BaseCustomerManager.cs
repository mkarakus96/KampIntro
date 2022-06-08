﻿using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerCheckService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db  :" + customer.FirstName);
        }

        public static implicit operator BaseCustomerManager(StarbucksCustomerManager v)
        {
            throw new NotImplementedException();
        }
    }
}
