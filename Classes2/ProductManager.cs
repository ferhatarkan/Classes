using System;
using System.Collections.Generic;
using System.Text;

namespace Classes2
{
    //reusability kuralı
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün  sisteme eklendi:"+product.ProductName);
        }
    }
}
