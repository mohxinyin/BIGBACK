using BIGBACK.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BIGBACK.Configurations.Entities
{
    public class RiderSeed : IEntityTypeConfiguration<Rider>
    {
        public void Configure(EntityTypeBuilder<Rider> builder)
        {
            builder.HasData(
               new Rider
               {
                   Id = 1,
                   RiderName = "Charlie Brown",
                   RiderContact = "+1122334455",
                   RiderRating = 4.8,
                   CreatedBy = "5781efa7-63dc-49f0-760f-e506d04102e4",
                   UpdatedBy = "5781efa7-63dc-49f0-760f-e506d04102e4"

               },
                new Rider
                {
                    Id = 2,
                    RiderName = "Daisy Lee",
                    RiderContact = "+2233445566",
                    RiderRating = 4.5,
                    CreatedBy = "9781ifa7-63hc-48f0-700f-e506d04102e4",
                    UpdatedBy = "9781ifa7-63hc-48f0-700f-e506d04102e4"

                });

        }
    }
}
