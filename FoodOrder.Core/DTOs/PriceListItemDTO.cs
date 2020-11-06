using System;
using System.Collections.Generic;
using System.Text;

namespace FoodOrder.Core.DTOs
{
    public class PriceListItemDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid PriceListId { get; set; }

        public Guid ProductId { get; set; }
    }
}
