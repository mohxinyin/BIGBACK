namespace BIGBACK.Domain
{
    public class Payment: BaseDomainModel
    {
        public DateTime PaymentDateTime { get; set; }
        public int? PaymentAmount { get; set; }
        public string? PaymentMethod { get; set; }
        public string? PaymentStatus { get; set; }
        public int OrderId { get; set; }

    }
}
