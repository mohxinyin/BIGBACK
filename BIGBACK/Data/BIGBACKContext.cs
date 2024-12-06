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
        public DbSet<BIGBACK.Domain.Complaint> Complaint { get; set; } = default!;
        public DbSet<BIGBACK.Domain.Delivery> Delivery { get; set; } = default!;
        public DbSet<BIGBACK.Domain.DeliveryRider> DeliveryRider { get; set; } = default!;
        public DbSet<BIGBACK.Domain.Rider> Rider { get; set; } = default!;
        public DbSet<BIGBACK.Domain.Staff> Staff { get; set; } = default!;
        public DbSet<BIGBACK.Domain.BusinessOwner> BusinessOwner { get; set; } = default!;
        public DbSet<BIGBACK.Domain.Business> Business { get; set; } = default!;
        public DbSet<BIGBACK.Domain.Menu> Menu { get; set; } = default!;
        public DbSet<BIGBACK.Domain.MenuItem> MenuItem { get; set; } = default!;
    }
}
