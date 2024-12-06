namespace BIGBACK.Domain
{
    public class Menu:BaseDomainModel
    {
        public int MenuId { get; set; }
        public string? MenuName { get; set; }
        public int BusinessId { get; set; }
        public string? MenuCategory { get; set; }
    }
}
