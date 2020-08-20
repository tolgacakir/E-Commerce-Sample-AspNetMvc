using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceSample.Entities.Concrete
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
