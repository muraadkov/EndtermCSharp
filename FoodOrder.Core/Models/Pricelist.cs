using System;
using System.Collections.Generic;
using System.Text;

namespace FoodOrder.Core.Models
{
    public class Pricelist
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime CreatedAt { get; set; }

        public List<PricelistItem> PricelistItems { get; set; }
    }
}
