namespace BIGBACK.Domain
{
    public class Order: BaseDomainModel
    {
        public DateTime OrderDateTime { get; set; }
        public string? OrderStatus { get; set; }
        public decimal? OrderTotal { get; set; }
        public int CustomerId { get; set; }

        public Customer? Customer { get; set; } // Naviagtion Property
    }
}
