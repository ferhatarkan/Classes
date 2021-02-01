using Project4.DataAccess;
using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.Busıness
{
    public class ProductManager
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
           

            //İş Kodları yazılır
            return _productDal.GetAll();
        }
    }
}
