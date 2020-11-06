using FoodOrder.Core.Models;
using FoodOrder.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrder
{
    public class FoodContext : DbContext
    {
        public FoodContext(DbContextOptions<FoodContext> options): base(options) { }
        public DbSet<Meal> Meal { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Order> Order { get; set; }

        public DbSet<Pricelist> PriceList { get; set; }

        public DbSet<PricelistItem> PricelistItems { get; set; }
    }
}
