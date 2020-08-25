using ECommerceSample.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerceSample.Entities.Concrete
{
    public class Product : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public short CategoryId { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
