using BIGBACK.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BIGBACK.Configurations.Entities
{
    public class DeliveryRiderSeed : IEntityTypeConfiguration<DeliveryRider>
    {
        public void Configure(EntityTypeBuilder<DeliveryRider> builder)
        {
            builder.HasData(
                new DeliveryRider
                {
                    Id = 1,
                    DeliveryRiderTaskType = "Pickup",
                    DeliveryRiderStatus = "Assigned",
                    DeliveryId = 1,
                    RiderId = 1
                },
                new DeliveryRider
                {
                    Id = 2,
                    DeliveryRiderTaskType = "Drop-off",
                    DeliveryRiderStatus = "In Transit",
                    DeliveryId = 2,
                    RiderId = 2
                }
            );


        }
    }
}
