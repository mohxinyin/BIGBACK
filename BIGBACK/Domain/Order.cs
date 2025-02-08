using System.ComponentModel.DataAnnotations.Schema;

namespace BIGBACK.Domain
{
    public class Order: BaseDomainModel
    {
        public DateTime OrderDateTime { get; set; }
        public string? OrderStatus { get; set; }
        public decimal? OrderTotal { get; set; }
        public int CustomerId { get; set; }
        public int RiderId { get; set; }
        public int StaffId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; } // Naviagtion Property

        [ForeignKey("StaffId")]
        public Staff? Staff { get; set; }

        [ForeignKey("RiderId")]
        public Rider? Rider { get; set; }
    }
}
