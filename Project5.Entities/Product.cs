using System;
using System.Collections.Generic;
using System.Text;

namespace Project5.Entities
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal ProductPrice { get; set; }
        public int UnitInStock { get; set; }
        
    }
}
