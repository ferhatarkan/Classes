using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.Entities
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
    }
}
