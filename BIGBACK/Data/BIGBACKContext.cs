using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BIGBACK.Domain;

namespace BIGBACK.Data
{
    public class BIGBACKContext : DbContext
    {
        public BIGBACKContext (DbContextOptions<BIGBACKContext> options)
            : base(options)
        {
        }

        public DbSet<BIGBACK.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<BIGBACK.Domain.Order> Order { get; set; } = default!;
        public DbSet<BIGBACK.Domain.OrderItem> OrderItem { get; set; } = default!;
        public DbSet<BIGBACK.Domain.Payment> Payment { get; set; } = default!;
    }
}
