using BIGBACK.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BIGBACK.Configurations.Entities
{
    public class OrderSeed : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
                 new Order
                 {
                     Id = 1,
                     OrderDateTime = DateTime.Now,
                     OrderStatus = "Pending",
                     OrderTotal = 64.50m,
                     CustomerId = 1,
                 },
                 new Order
                 {
                     Id = 2,
                     OrderDateTime = DateTime.Now,
                     OrderStatus = "Pending",
                     OrderTotal = 55.70m,
                     CustomerId = 2,
                 }
             );
        }
    }
}
