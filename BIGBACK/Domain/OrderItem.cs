namespace BIGBACK.Domain
{
    public class OrderItem : BaseDomainModel
    {
        public int? OrderItemQty { get; set; }
        public string? OrderItemPromo { get; set; }
        public int OrderId { get; set; }
        public int MenuItemId {get; set;}
    }
}
