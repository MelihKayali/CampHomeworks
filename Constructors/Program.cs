using System;

namespace Constructors // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id=1 , FirstName="Melih" , LastName="Kayalı" , City="Ankara"};
            Customer customer1 = new Customer(2 , "Sezer" , "Tetik" , "Ankara" );
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Demir";
            Console.WriteLine(customer3.FirstName);
        }
    }

    class Customer
    {
        public Customer(int Id , string FirstName , string LastName , string City)
        {
            Id = Id;
            FirstName = FirstName;
            LastName = LastName;
            City = City;
        }

        //Default costructor
        public Customer()
        {
            Console.WriteLine("Costructor is working!");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string City { get; set; }
    }
}