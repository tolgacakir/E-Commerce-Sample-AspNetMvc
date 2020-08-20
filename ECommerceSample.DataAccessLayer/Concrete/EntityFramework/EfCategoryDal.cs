using ECommerceSample.Core.DataAccess.EntityFramework;
using ECommerceSample.DataAccessLayer.Abstract;
using ECommerceSample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceSample.DataAccessLayer.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, ECommerceContext>, ICategoryDal
    {
    }
}
