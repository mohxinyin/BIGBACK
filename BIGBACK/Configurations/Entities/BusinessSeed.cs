using BIGBACK.Domain;
using Microsoft.EntityFrameworkCore;

namespace BIGBACK.Configurations.Entities
{
    public class BusinessSeed : IEntityTypeConfiguration<Business>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Business> builder)
        {
            builder.HasData(
                 new Business
                 {
                     Id = 1,
                     BusinessName = "Anna's Bakery",
                     BusinessAddress = "3 Tampines Ave",
                     BusinessContact = "69876543",
                     BusinessRating = "Excellent",
                     BusinessStatus = "Open",
                     BusinessOwnerId = 1,
                 },
                 new Business
                 {
                     Id = 2,
                     BusinessName = "NanXiang Chicken Rice",
                     BusinessAddress = "2 Tampines Ave",
                     BusinessContact = "68765432",
                     BusinessRating = "Excellent",
                     BusinessStatus = "Open",
                     BusinessOwnerId = 2,
                 }
             );
        }
    }
}
