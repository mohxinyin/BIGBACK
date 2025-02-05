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
             new IdentityUserRole<string> //businessowner- anna
             {
                 RoleId = "cd2bcf0c-20db-474f-8407-5a6b159518ba",
                 UserId = "4781efa7-68dc-47f2-850f-e506d04102e4"
             },
             new IdentityUserRole<string> //businessowner -jimmy
             {
                 RoleId = "cd2bcf0c-20db-474f-8407-5a6b159518ba",
                 UserId = "7651efa7-68dc-47f2-850f-e506d04102e4"
             },
             new IdentityUserRole<string> //rider-charlie
             {
                 RoleId = "dd2bcf0c-20db-474f-8407-5a6b159518bb",
                 UserId = "5781efa7-63dc-49f0-760f-e506d04102e4"
             },
             new IdentityUserRole<string> //rider-daisylee
             {
                 RoleId = "dd2bcf0c-20db-474f-8407-5a6b159518bb",
                 UserId = "9781ifa7-63hc-48f0-700f-e506d04102e4"
             },
             new IdentityUserRole<string> //customer-johndoe
             {
                 RoleId = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                 UserId = "7851efa7-69dc-47f2-890f-e507d04107e4"
             },
             new IdentityUserRole<string> //customer-maryjane
             {
                 RoleId = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                 UserId = "8851efa7-69dc-49f2-790f-e506d04197e4"
             }

            );
        }
    }
}