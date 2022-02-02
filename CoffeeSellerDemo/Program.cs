using CoffeeSellerDemo.Abstracts;
using CoffeeSellerDemo.Concretes;
using CoffeeSellerDemo.Entities;
using System;

namespace CoffeeSellerDemo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer();
            customer.DateOfBirth = DateTime.Now;
            customer.FirstName = "Melih";
            customer.LastName = "Kayalı";
            customer.NationaltyId = "234123";
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(customer);
        }
    }
}