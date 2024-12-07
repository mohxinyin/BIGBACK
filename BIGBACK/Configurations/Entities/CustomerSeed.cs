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
                 },
                 new Customer
                 {
                     Id = 2,
                     CustomerName = "Mary Jane",
                     CustomerMobileNumber = "91054379",
                     CustomerAddress = "3 Yishun Ave",
                     CustomerGender = "Female",
                     CustomerEmail = "maryjane2@gmail.com",
                 }
             );
        }
    }
}
