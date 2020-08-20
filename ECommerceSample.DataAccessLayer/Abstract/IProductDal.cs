using ECommerceSample.Core.DataAccess;
using ECommerceSample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceSample.DataAccessLayer.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
