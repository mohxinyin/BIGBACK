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
                },
                new BIGBACKUser // businessowner email
                {
                    Id = "7651efa7-68dc-47f2-850f-e506d04102e4",
                    Email = "business_jimmyChicken@localhost.com",
                    NormalizedEmail = "BUSINESS_JIMMYCHICKEN@LOCALHOST.COM",
                    FirstName = "Jimmy",
                    LastName = "Businessowner",
                    UserName = "business_jimmyChicken@localhost.com",
                    NormalizedUserName = "BUSINESS_JIMMYCHICKEN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword4"),
                    EmailConfirmed = true // Set to true, otherwise you won't be able to login    
                },

                new BIGBACKUser // customer email
                {
                    Id = "7851efa7-69dc-47f2-890f-e507d04107e4",
                    Email = "johndoe1@gmail.com",
                    NormalizedEmail = "JOHNDOE1@GMAIL.COM",
                    FirstName = "John",
                    LastName = "Doe",
                    UserName = "johndoe1@gmail.com",
                    NormalizedUserName = "JOHNDOE1@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword5"),
                    EmailConfirmed = true // Set to true, otherwise you won't be able to login    
                },

                new BIGBACKUser // customer email
                {
                    Id = "8851efa7-69dc-49f2-790f-e506d04197e4",
                    Email = "maryjane2@gmail.com",
                    NormalizedEmail = "MARYJANE2@GMAIL.COM",
                    FirstName = "Mary",
                    LastName = "Jane",
                    UserName = "maryjane2@gmail.com",
                    NormalizedUserName = "MARYJANE2@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword6"),
                    EmailConfirmed = true // Set to true, otherwise you won't be able to login    
                },
                new BIGBACKUser // rider email
                {
                    Id = "9781ifa7-63hc-48f0-700f-e506d04102e4",
                    Email = "rider_daisylee@localhost.com",
                    NormalizedEmail = "RIDER_DAISYLEE@LOCALHOST.COM",
                    FirstName = "Daisy",
                    LastName = "Lee",
                    UserName = "rider_daisylee@localhost.com",
                    NormalizedUserName = "RIDER_DAISYLEE@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword7"),
                    EmailConfirmed = true // Set to true, otherwise you won't be able to login    
                }


            );
        }
    }
}