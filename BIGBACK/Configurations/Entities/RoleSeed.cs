using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BIGBACK.Configurations.Entities
{
    public class RoleSeed : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                 new IdentityRole
                 {
                     Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                     Name = "Administrator",
                     NormalizedName = "ADMINISTRATOR" //Staff
                 },
                 new IdentityRole
                 {
                     Id = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                     Name = "User",
                     NormalizedName = "USER"  // customer
                 },
                 new IdentityRole
                 {
                     Id = "cd2bcf0c-20db-474f-8407-5a6b159518ba",
                     Name = "BusinessOwner",
                     NormalizedName = "BUSINESSOWNER" //businessOwner
                 },
                 new IdentityRole
                 {
                     Id = "dd2bcf0c-20db-474f-8407-5a6b159518bb",
                     Name = "Rider",
                     NormalizedName = "RIDER" //rider
                 }
             );
        }
    }
}