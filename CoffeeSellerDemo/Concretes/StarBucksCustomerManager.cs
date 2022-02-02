using CoffeeSellerDemo.Abstracts;
using CoffeeSellerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSellerDemo.Concretes
{
    public class StarBucksCustomerManager:BaseCustomerManager
    {   
        private IPersonCheckService personCheckService;
        public StarBucksCustomerManager(IPersonCheckService personCheckService)
        {
            personCheckService = personCheckService;
        }
        public override void Save(Customer customer)
        {
            if (personCheckService.CheckIfRealService(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
            
        }

    }
}
