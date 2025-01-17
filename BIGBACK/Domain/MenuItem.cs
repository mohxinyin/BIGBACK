namespace BIGBACK.Domain
{
    public class MenuItem: BaseDomainModel

    {
        public float MenuItemPrice { get; set; }
        public string? MenuItemName { get; set; }
        public string? MenuItemDesc { get; set; }
        public int MenuId { get; set; }
       
        // Navigation property
        public Menu? Menu { get; set; }
    }
}
