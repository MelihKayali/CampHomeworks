using CoffeeSellerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSellerDemo.Abstracts
{
    public interface IPersonCheckService
    {
        bool CheckIfRealService(Customer customer);
    }
}
