using System;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() { ProductName="Laptop", UnitsInStock=5000,UnitPrice=5};
           
            
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
