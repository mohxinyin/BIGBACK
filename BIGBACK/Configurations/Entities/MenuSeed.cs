using BIGBACK.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BIGBACK.Configurations.Entities
{
    public class MenuSeed : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasData(
                  new Menu
                  {
                      Id = 1,
                      MenuCategory = "Cakes",
                      MenuName = "Anna's bakery book",
                      BusinessId= 1,
                  },
                  new Menu
                  {
                      Id = 2,
                      MenuCategory = "Chicken Rice",
                      MenuName = "Chicken Rice Delights",
                      BusinessId = 2,
                  }
              );
        }
    }
}
