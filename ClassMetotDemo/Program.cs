using System;

namespace ClassMetotDemo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Ahmet";
            customer.LastName = "Hamet";
            customer.IdentityNumber = "12434523792222";


            Customer customer1 = new Customer();
            customer1.Id = 2;
            customer1.FirstName = "Mehmet";
            customer1.LastName = "Dürümcü";
            customer1.IdentityNumber = "124345223435331222";


            Customer customer2 = new Customer();
            customer2.Id = 3;
            customer2.FirstName = "Zeliha";
            customer2.LastName = "Aynacı";
            customer2.IdentityNumber = "124345232951222";
            

            Customer[] customers = new Customer[] { customer , customer1, customer2 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.delete(customer);
            customerManager.getAll(customers);
        }
    }
}
