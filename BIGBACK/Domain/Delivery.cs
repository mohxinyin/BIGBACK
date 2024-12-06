namespace BIGBACK.Domain
{
    public class Delivery : BaseDomainModel
    {
        public int DeliveryId { get; set; }
        public DateTime DeliveryTime { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        public int BusinessID { get; set; }
        public decimal DeliveryFee { get; set; }
        public string? DeliveryStatus { get; set; }
    }
}
