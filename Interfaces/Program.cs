using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            //İnterface ler new lenemez...
           // IPersonManager customerManager = new CustomerManager();

           // IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());
            projectManager.Update(new EmployeeManager());
            projectManager.Update(new InternManager());
        }
    }

    // implemented--tamamlanmış
    interface IPersonManager
    {
        // unimplamenting
        void Add();
        void Update();
    }
    //Inherits -class-----------implements-İnterface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            //Müşteri güncelleme kodları
            Console.WriteLine("Müşteri güncellendi");

        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //Personel ekleme kodları
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            //Personel güncelleme kodları
            Console.WriteLine("Personel güncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)//Interface deki add le bbir alakası yok
        {
            personManager.Add();
            
        }
        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }
    }
}
