using System;

namespace InterfacesDemo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();

            IPersonManager employeeManager = new EmployeeManager();
            
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(employeeManager);
        }
    }

    interface IPersonManager
    {
         void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi.");
        }
    }


    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi.");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            
            personManager.Add();
        }
    }

}