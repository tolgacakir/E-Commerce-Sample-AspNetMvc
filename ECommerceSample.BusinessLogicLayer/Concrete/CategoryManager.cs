﻿using ECommerceSample.BusinessLogicLayer.Abstract;
using ECommerceSample.DataAccessLayer.Abstract;
using ECommerceSample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceSample.BusinessLogicLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
