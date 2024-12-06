namespace BIGBACK.Domain
{
    public class DeliveryRider : BaseDomainModel
    {
        public string? DeliveryRiderTaskType { get; set; }
        public string? DeliveryRiderStatus { get; set; }
        public int DeliveryId { get; set; }
        public int RiderId { get; set; }
    }
}
