using System;

namespace Classes // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Melih";
            customer.LastName = "Kayalı";
            customer.City = "Ankara";

            Customer customer2 = new Customer {Id= 2 , FirstName = "Yusuf" , LastName="Ağcı" , City="Ankara" };

            Console.WriteLine(customer2.FirstName);
        }

    }    
}