using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class CustomerManager
    {
        //Constructor-- new lendiğinde
        //çalışan bloktur.new()
        public CustomerManager()
        {
            customers = new List<Customer>()
            {
                new Customer {
                    Id = 1,
                    FirsName = "Engin",
                    LastName = "Demiroğ",
                    City = "Ankara",
                    Email = "engin@"
                },
                new Customer
                {
                    Id = 1,
                    FirsName = "Derin",
                    LastName = "Demiroğ",
                    City = "Ankara",
                    Email = "derin@"
                },
                new Customer
                {
                    Id = 1,
                    FirsName = "Salih",
                    LastName = "Demiroğ",
                    City = "Ankara",
                    Email = "salih@"
                },
                new Customer
                {
                    Id = 1,
                    FirsName = "Ahmet",
                    LastName = "Demiroğ",
                    City = "İstanbul",
                    Email = "ahmet@"
                },
                new Customer
                {
                    Id = 1,
                    FirsName = "Mehmet",
                    LastName = "Demiroğ",
                    City = "İzmir",
                    Email = "mehmet@"
                }

            };
        }
        List<Customer> customers;
        public List<Customer> GetAll()
        {
            //Veritabanına bağlan
            
         return customers; 
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
    }
}
