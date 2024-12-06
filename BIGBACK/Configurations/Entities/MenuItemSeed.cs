using BIGBACK.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BIGBACK.Configurations.Entities
{
    public class MenuItemSeed : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> builder)
        {
            builder.HasData(
                  new MenuItem
                  {
                      Id = 1,
                      MenuId = 1,
                      MenuItemDesc = "A rich, moist milk chocolate cake with a velvety texture and irresistible chocolate flavor, perfect for any sweet craving.",
                      MenuItemName = "Milk Chocolate Cake",
                      MenuItemPrice = 32,
                  },
                  new MenuItem
                  {
                      Id = 2,
                      MenuId = 2,
                      MenuItemDesc = "A savory dish of tender roasted chicken served with fragrant, perfectly seasoned rice for a satisfying meal",
                      MenuItemName = "Roasted Chicken Rice",
                      MenuItemPrice = 5,
                  }
              );
        }
    }
}
