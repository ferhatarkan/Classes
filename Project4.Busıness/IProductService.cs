﻿using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.Busıness
{
    interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Delete(Product product); 
        void Update(Product product);
     
    }
}
