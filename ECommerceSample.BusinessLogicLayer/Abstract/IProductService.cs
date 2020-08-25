using ECommerceSample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceSample.BusinessLogicLayer.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategoryId(short categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        Product GetById(int productId);

    }
}
