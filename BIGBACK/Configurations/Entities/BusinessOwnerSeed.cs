using BIGBACK.Domain;
using Microsoft.EntityFrameworkCore;

namespace BIGBACK.Configurations.Entities
{
    public class BusinessOwnerSeed : IEntityTypeConfiguration<BusinessOwner>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<BusinessOwner> builder)
        {
            builder.HasData(
                new BusinessOwner
                {
                    Id = 1,
                    BusinessOwnerName = "Anna",
                    BusinessOwnerrContact = "97564437",
                    BusinessOwnerEmail = "annatan@gmail.com",
                    BusinessOwnerGender = "Female"
                },
                new BusinessOwner
                {
                    Id = 2,
                    BusinessOwnerName = "Jimmy",
                    BusinessOwnerrContact = "97524338",
                    BusinessOwnerEmail = "JimmyLeong@gmail.com",
                    BusinessOwnerGender = "Male"
                }
            );

        }
    }
}
