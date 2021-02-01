﻿using System;

namespace Inharitance
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            personManager.Add();

            CustomerManager customerManager = new CustomerManager();
            customerManager.GetBestCustomer();

            EmployeeManager employeeManager = new EmployeeManager();
            employeeManager.GetBestEmployee();

        }

    }
    class PersonManager
    {
        public void Add()
        {
            Console.WriteLine("Eklendi....");
        }
        public void Update()
        {
            Console.WriteLine("Güncellendi..");
        }
    }
    class CustomerManager:PersonManager
    {
        public void GetBestCustomer()
        {

        }
    }

    class EmployeeManager:PersonManager
    {
        public void GetBestEmployee()
        {

        }
    }

    class Person
    {
        public int Id { get; set; } //Database ıd
        public string NationalIdentity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Employee:Person
    {
        public string EmployeeNumber { get; set; }
    }

    class Customer
    {
        public string CrediCardNumber { get; set; }
    }
}
