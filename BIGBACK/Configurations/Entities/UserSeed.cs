using BIGBACK.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BIGBACK.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<BIGBACKUser>
    {
        public void Configure(EntityTypeBuilder<BIGBACKUser> builder)
        {
            var hasher = new PasswordHasher<BIGBACKUser>();
            builder.HasData(
                new BIGBACKUser // staff email
                {
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "Admin",
                    LastName = "User",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true // Set to true, otherwise you won't be able to login    
                },
                new BIGBACKUser // businessowner email
                {
                    Id = "4781efa7-68dc-47f2-850f-e506d04102e4",
                    Email = "business_annaBakery@localhost.com",
                    NormalizedEmail = "BUSINESS_ANNABAKERY@LOCALHOST.COM",
                    FirstName = "Anna",
                    LastName = "Businessowner",
                    UserName = "business_annaBakery@localhost.com",
                    NormalizedUserName = "BUSINESS_ANNABAKERY@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword2"),
                    EmailConfirmed = true // Set to true, otherwise you won't be able to login    
                },
                new BIGBACKUser // rider email
                {
                    Id = "5781efa7-63dc-49f0-760f-e506d04102e4",
                    Email = "rider_charlie@localhost.com",
                    NormalizedEmail = "RIDER_CHARLIE@LOCALHOST.COM",
                    FirstName = "Charlie",
                    LastName = "Brown",
                    UserName = "rider_charlie@localhost.com",
                    NormalizedUserName = "RIDER_CHARLIE@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword3"),
                    EmailConfirmed = true // Set to true, otherwise you won't be able to login    
                }

            );
        }
    }
}