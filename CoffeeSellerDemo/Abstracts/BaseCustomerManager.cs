using CoffeeSellerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSellerDemo.Abstracts
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            //virtual sayesinde kodu ezebiliriz(override)
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}
