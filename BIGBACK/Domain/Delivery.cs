namespace BIGBACK.Domain
{
    public class Delivery : BaseDomainModel
    {
        public DateTime DeliveryTime { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        public int BusinessID { get; set; }
        public decimal DeliveryFee { get; set; }
        public string? DeliveryStatus { get; set; }


        // Navigation properties
        public Customer? Customer { get; set; }
        public Order? Order { get; set; }
        public Business? Business { get; set; }

        // Navigation property to DeliveryRider (this is the bridge to Rider)
        public DeliveryRider? DeliveryRider { get; set; }
    }
}
