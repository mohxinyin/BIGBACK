using BIGBACK.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BIGBACK.Configurations.Entities
{
    public class PaymentSeed : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasData(
                  new Payment
                  {
                      Id = 1,
                      PaymentDateTime = DateTime.Now,
                      PaymentAmount = 64.50m,
                      PaymentMethod = "VISA Debit",
                      PaymentStatus = "Completed",
                      OrderId = 1,
                  },
                  new Payment
                  {
                      Id = 2,
                      PaymentDateTime = DateTime.Now,
                      PaymentAmount = 55.70m,
                      PaymentMethod = "PayNow",
                      PaymentStatus = "Completed",
                      OrderId = 2,
                  }
              );
        }
    }
}
