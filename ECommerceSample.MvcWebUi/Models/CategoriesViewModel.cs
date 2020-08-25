using ECommerceSample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceSample.MvcWebUi.Models
{
    public class CategoriesViewModel
    {
        public List<Category> Categories { get; set; }
        public Category Category { get; set; }
    }
}
