using CoffeeSellerDemo.Abstracts;
using CoffeeSellerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSellerDemo.Concretes
{
    public class CustomerCheckManager : IPersonCheckService
    {
        public bool CheckIfRealService(Customer customer)
        {
            return true;
        }
    }
}
