using ECommerceSample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceSample.MvcWebUi.Models
{
    public class ProductAndCategoryListViewModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public Category CurrentCategory { get; set; }

    }
}
