using BIGBACK.Domain;
using BIGBACK.Migrations;
using Microsoft.AspNetCore.Http.HttpResults;
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
                    BusinessOwnerEmail = "business_annaBakery@localhost.com",
                    BusinessOwnerGender = "Female",
                    CreatedBy = "4781efa7-68dc-47f2-850f-e506d04102e4",
                    UpdatedBy = "4781efa7-68dc-47f2-850f-e506d04102e4"


                },
                new BusinessOwner
                {
                    Id = 2,
                    BusinessOwnerName = "Jimmy",
                    BusinessOwnerrContact = "97524338",
                    BusinessOwnerEmail = "business_jimmyChicken@localhost.com",
                    BusinessOwnerGender = "Male",
                    CreatedBy = "7651efa7-68dc-47f2-850f-e506d04102e4",
                    UpdatedBy = "7651efa7-68dc-47f2-850f-e506d04102e4"

                }  
                    
            );

        }
    }
}
