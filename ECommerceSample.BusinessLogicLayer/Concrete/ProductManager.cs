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

        public List<Product> GetByCategory(Category category)
        {
            return _productDal.GetList(p => p.CategoryId == category.Id);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
