
using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.DataAccess
{
    //Data Access lair-- veri erişim kodu 
    public class ProductDal:IProductDal 
    {
        //Ado.Net
        List<Product> _products;
        public ProductDal()
        {

            _products = new List<Product>
            {
                new Product{ProductId=1, ProductName="Acer Bilgisayar",
                            QuantityPerUnit="32 Gb Ram ",
                            UnitPrice=10000,UnitInStock=2},
                new Product{ProductId=2, ProductName="Asus Bilgisayar",
                            QuantityPerUnit="32 Gb Ram ",
                            UnitPrice = 10000,UnitInStock=1},
                new Product{ProductId=3,ProductName="HP Bilgisayar",
                            QuantityPerUnit="32 Gb Ram ",
                            UnitPrice=10000,UnitInStock=0},
                new Product{ProductId=4,ProductName="Mac Bilgisayar",
                            QuantityPerUnit="32 Gb Ram ",
                            UnitPrice=10000,UnitInStock=3},
                new Product{ProductId=5,ProductName="Dell Bilgisayar",
                            QuantityPerUnit="32 Gb Ram ",
                            UnitPrice=10000,UnitInStock=10}
            };
        }

        public void Add(Product product)
        {
            Console.WriteLine("Ado.NET ile eklendi");
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
