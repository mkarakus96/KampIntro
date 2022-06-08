using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            CheckIfRealPerson(customer);
            base.Save(customer);
        }

        private void CheckIfRealPerson(Customer customer)
        {
            
        }
    }
}
