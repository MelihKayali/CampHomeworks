using System;

namespace ReferanceTypes // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number1 = number2;
            number2 = 100; 
            Console.WriteLine(number1);

            int[] numbers1 = new int[] { 1, 2, 3 };
            int[] numbers2 = new int[] {10,20, 30 };

            numbers1 = numbers2;
            numbers2[0] = 1000;
            Console.WriteLine(numbers1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            
            person1.FirstName = "Melih";
            person1 = person2;
            //Person2's FirstName is Melih.
            Console.WriteLine(person1.FirstName);


            Customer customer1 = new Customer();
            customer1.FirstName = "xx";
            customer1.CreditCartNumber = "786513121";
            Employee employee1 = new Employee();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
    }

    class Customer : Person
    {
        public string CreditCartNumber{ get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}