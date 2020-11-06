﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FoodOrder.Core.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }

        public string Description { get; set; }

    }
}
