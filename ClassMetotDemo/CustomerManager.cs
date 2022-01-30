using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer added by ıd : " + customer.Id);
        }

        public void delete(Customer customer)
        {
            Console.WriteLine("Customer deleted by ıd : " + customer.Id);
        }

        public void getAll(Customer[] customers)
        {   
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id + " " + customer.FirstName + " " + customer.LastName + " " + customer.IdentityNumber);
            }
            Console.WriteLine("-----");
            
        }
    }
}
