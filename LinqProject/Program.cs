using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Bilgisayar"},
                new Category{CategoryId=2,CategoryName="Telefon"}
            };
            List<Product> products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32 Gb Ram",UnitInStock=5,UnitPrice=10000},
                new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="16 Gb Ram",UnitInStock=3,UnitPrice=8000},
                new Product{ProductId=3,CategoryId=1,ProductName="Hp Laptop",QuantityPerUnit="8 Gb Ram",UnitInStock=2,UnitPrice=6000},
                new Product{ProductId=4,CategoryId=2,ProductName="samsung Telefon",QuantityPerUnit="4 Gb Ram",UnitInStock=15,UnitPrice=5000},
                new Product{ProductId=5,CategoryId=2,ProductName="Apple Telefon",QuantityPerUnit="4 Gb Ram",UnitInStock=0,UnitPrice=8000}

            };
            //Test(products);
            // AnyTest(products);
            //FindTest(products);
            //FindAllTest(products);
            //AscDescTest(products);
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.UnitPrice descending,p.ProductName ascending
                         select p;
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void AscDescTest(List<Product> products)
        {
            //Single line query
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.ProductName);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 15);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer Laptop");
            Console.WriteLine(result);
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algoritmik-------------------------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            Console.WriteLine("Linq-------------------------");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        static List<Product> GetProducts(List<Product> products)
        {
             return products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList();
        }
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
