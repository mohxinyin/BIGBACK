namespace BIGBACK.Domain
{
    public class Payment: BaseDomainModel
    {
        public DateTime PaymentDateTime { get; set; }
        public decimal? PaymentAmount { get; set; }
        public string? PaymentMethod { get; set; }
        public string? PaymentStatus { get; set; }
        public int OrderId { get; set; }

        // Navigation property
        public Order? Order { get; set; }

    }
}
