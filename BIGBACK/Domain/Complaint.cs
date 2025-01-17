namespace BIGBACK.Domain
{
    public class Complaint : BaseDomainModel
    { 
        public int OrderId { get; set; }
        public int StaffId { get; set; }
        public int RiderId { get; set; }
        public string? ComplaintDesc { get; set; }
        public string? ComplaintStatus {  get; set; }
        public DateTime ComplaintDateTime { get; set; }


        // Navigation properties
        public Order? Order { get; set; }
        public Staff? Staff { get; set; }
        public Rider? Rider { get; set; }

    }
}
