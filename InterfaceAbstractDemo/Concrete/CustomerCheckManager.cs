using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public void CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
