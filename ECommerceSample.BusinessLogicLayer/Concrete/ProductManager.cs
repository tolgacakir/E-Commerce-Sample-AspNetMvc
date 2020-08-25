using ECommerceSample.BusinessLogicLayer.Abstract;
using ECommerceSample.DataAccessLayer.Abstract;
using ECommerceSample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceSample.BusinessLogicLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategoryId(short categoryId)
        {
            var x= _productDal.GetList(p => p.CategoryId == categoryId || categoryId==0);
            return x;
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(m => m.Id == productId);
        }

    }
}
