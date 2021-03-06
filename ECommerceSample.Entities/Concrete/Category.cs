﻿using ECommerceSample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceSample.Entities.Concrete
{
    public class Category : IEntity
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
    }
}
