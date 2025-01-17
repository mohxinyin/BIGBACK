namespace BIGBACK.Domain
{
    public class OrderItem : BaseDomainModel
    {
        public int? OrderItemQty { get; set; }
        public string? OrderItemPromo { get; set; }
        public int OrderId { get; set; }
        public int MenuItemId { get; set; }


        // Navigation properties
        public Order? Order { get; set; }
        public MenuItem? MenuItem { get; set; }
    }
}
