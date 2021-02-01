using Project4.Busıness;
using Project4.DataAccess;
using System;

namespace Project4.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new ProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
           
        }
    }
}
