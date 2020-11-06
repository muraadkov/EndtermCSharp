using System;
using System.Collections.Generic;
using System.Text;

namespace FoodOrder.Core.Models
{
    public class PricelistItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid PriceListId { get; set; }

        public Guid ProductId { get; set; }

    }
}
