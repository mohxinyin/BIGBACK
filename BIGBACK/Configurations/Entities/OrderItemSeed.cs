using BIGBACK.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BIGBACK.Configurations.Entities
{
    public class OrderItemSeed : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasData(
                 new OrderItem
                 {
                     Id = 1,
                     OrderItemQty = 1,
                     OrderItemPromo = null,
                     OrderId = 1,
                     MenuItemId = 1,
                     
                 },
                 new OrderItem
                 {
                     Id = 2,
                     OrderItemQty = 2,
                     OrderItemPromo = "NEWCUSTOMER25",
                     OrderId = 2,
                     MenuItemId = 2,
                 }
             );
        }
    }
}
