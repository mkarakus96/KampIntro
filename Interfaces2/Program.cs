using System;

namespace Interfaces2
{
    class Program
    {
        // interface newlenemez
        static void Main(string[] args)
        {
            //IPersonManager personManager = new CustomerManager();
            //personManager.Add();
            //IPersonManager personManager1 = new EmployeeManager();
            //personManager1.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
        }
    }
    interface IPersonManager // arayüz - şablon
    {
        void Add();
        void Update();
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
        
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi");
        }
    }
}
