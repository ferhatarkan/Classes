using Project4.Busıness;
using Project4.DataAccess;
using Project4.Entities;
using System;

namespace Project4.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            // productManager.Delete(new Product { ProductId=78, ProductName = "Masa2",CategoryID=2, QuantityPerUnit = "6 Ayaklı masa", UnitPrice = 10100, UnitsInStock = 4 });
            Console.WriteLine(productManager.GetById(1).ProductName);
            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            //try
            //{
            //    productManager.Add(new Product { ProductId = 10, ProductName = "Laptop", QuantityPerUnit = "4 Ayaklı masa", UnitPrice = 1000, UnitsInStock = 10 });
            //}
            //catch (DuplicateProductException exception)
            //{
            //    Console.WriteLine(exception.Message);
                
            //}
            
           
        }
    }
}
