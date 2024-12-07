using BIGBACK.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BIGBACK.Configurations.Entities
{
    public class DeliverySeed : IEntityTypeConfiguration<Delivery>
    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {
            builder.HasData(
                new Delivery
                {
                    Id = 1,
                    DeliveryDate = new DateTime(2024, 12, 8), 
                    DeliveryTime = new DateTime(2024, 12, 8, 10, 30, 0), 
                    CustomerID = 1,
                    OrderID = 1,
                    BusinessID = 1,
                    DeliveryFee = 5.99m,
                    DeliveryStatus = "Pending"
                },
                new Delivery
                {
                    Id = 2,
                    DeliveryDate = new DateTime(2024, 12, 9),
                    DeliveryTime = new DateTime(2024, 12, 9, 15, 45, 0),
                    CustomerID = 2,
                    OrderID = 2,
                    BusinessID = 1,
                    DeliveryFee = 7.49m,
                    DeliveryStatus = "Delivered"
                });

        }
    }
}
