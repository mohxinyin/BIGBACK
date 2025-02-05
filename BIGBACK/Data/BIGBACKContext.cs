using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BIGBACK.Data;
using BIGBACK.Configurations.Entities;
using System.Reflection.Emit;
using BIGBACK.Domain;

namespace BIGBACK.Data
{
    public class BIGBACKContext(DbContextOptions<BIGBACKContext> options) : IdentityDbContext<BIGBACKUser>(options)
    {
        
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new BusinessOwnerSeed());
            builder.ApplyConfiguration(new BusinessSeed());
            builder.ApplyConfiguration(new MenuItemSeed());
            builder.ApplyConfiguration(new MenuSeed());
            builder.ApplyConfiguration(new CustomerSeed());
            builder.ApplyConfiguration(new OrderSeed());
            builder.ApplyConfiguration(new OrderItemSeed());
            builder.ApplyConfiguration(new PaymentSeed());
            builder.ApplyConfiguration(new DeliverySeed());
            builder.ApplyConfiguration(new DeliveryRiderSeed());
            builder.ApplyConfiguration(new RiderSeed());
            builder.ApplyConfiguration(new StaffSeed());
            builder.ApplyConfiguration(new ComplaintSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
        }
    }
}
