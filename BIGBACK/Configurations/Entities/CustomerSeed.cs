using BIGBACK.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BIGBACK.Configurations.Entities
{
    public class CustomerSeed : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                 new Customer
                 {
                     Id = 1,
                     CustomerName = "John Doe",
                     CustomerMobileNumber = "91062378",
                     CustomerAddress = "3 AngMoKio Ave",
                     CustomerGender = "Male",
                     CustomerEmail = "johndoe1@gmail.com",
                     CreatedBy = "7851efa7-69dc-47f2-890f-e507d04107e4",
                     UpdatedBy = "7851efa7-69dc-47f2-890f-e507d04107e4"
                 },
                 new Customer
                 {
                     Id = 2,
                     CustomerName = "Mary Jane",
                     CustomerMobileNumber = "91054379",
                     CustomerAddress = "3 Yishun Ave",
                     CustomerGender = "Female",
                     CustomerEmail = "maryjane2@gmail.com",
                     CreatedBy = "8851efa7-69dc-49f2-790f-e506d04197e4",
                     UpdatedBy = "8851efa7-69dc-49f2-790f-e506d04197e4"
                 }
             );
        }
    }
}
