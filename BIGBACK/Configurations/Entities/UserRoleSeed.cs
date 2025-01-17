using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BIGBACK.Configurations.Entities
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
            new IdentityUserRole<string> //staff
            {
                RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
            },
             new IdentityUserRole<string> //businessowner
             {
                 RoleId = "cd2bcf0c-20db-474f-8407-5a6b159518ba",
                 UserId = "4781efa7-68dc-47f2-850f-e506d04102e4"
             },
              new IdentityUserRole<string> //rider
              {
                  RoleId = "dd2bcf0c-20db-474f-8407-5a6b159518bb",
                  UserId = "5781efa7-63dc-49f0-760f-e506d04102e4"
              }

            );
        }
    }
}