using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project4.DataAccess
{
    public class EfProductDal : IProductDal
    {
        //List<Product> _products;
        public EfProductDal()
        {
            //_products = new List<Product>
            //{
            //    new Product{ProductId=1, ProductName="Acer Ef Bilgisayar",
            //                QuantityPerUnit="32 Gb Ram ",
            //                UnitPrice=10000,UnitInStock=2},
            //    new Product{ProductId=2, ProductName="Asus Ef Bilgisayar",
            //                QuantityPerUnit="32 Gb Ram ",
            //                UnitPrice = 10000,UnitInStock=1},
            //    new Product{ProductId=3,ProductName="HP Ef Bilgisayar",
            //                QuantityPerUnit="32 Gb Ram ",
            //                UnitPrice=10000,UnitInStock=0},
            //    new Product{ProductId=4,ProductName="Mac Ef Bilgisayar",
            //                QuantityPerUnit="32 Gb Ram ",
            //                UnitPrice=10000,UnitInStock=3},
            //    new Product{ProductId=5,ProductName="Dell Ef Bilgisayar",
            //                QuantityPerUnit="32 Gb Ram ",
            //                UnitPrice=10000,UnitInStock=10}
            //};

        }


        public void Add(Product product)
        {

            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Remove(context.Products.SingleOrDefault(p=>p.ProductId==product.ProductId));
                context.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
            //Dispose-- bellekten uçur
        }

        public Product GetById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.SingleOrDefault(p=>p.ProductId==id);
            }
        }

        public void Update(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var productToUpdate=context.Products.SingleOrDefault(p=>p.ProductId==product.ProductId);
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.QuantityPerUnit = product.QuantityPerUnit;
                productToUpdate.UnitPrice = product.UnitPrice;
                productToUpdate.UnitsInStock = product.UnitsInStock;
                productToUpdate.CategoryID = product.CategoryID;
                context.SaveChanges();
            }
        }
    }
}