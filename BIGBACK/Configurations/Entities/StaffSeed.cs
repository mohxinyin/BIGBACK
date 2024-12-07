using BIGBACK.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BIGBACK.Configurations.Entities
{
    public class StaffSeed : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff
                {
                    Id = 1,
                    StaffName = "Alice Johnson",
                    StaffEmail = "alice.johnson@example.com",
                    StaffContact = "+1234567890"
                },
                
                new Staff
                {
                    Id = 2,
                    StaffName = "Bob Smith",
                    StaffEmail = "bob.smith@example.com",
                    StaffContact = "+0987654321"
                });

        }
    }
}
