namespace BIGBACK.Domain
{
    public class Complaint : BaseDomainModel
    { 
        public int OrderID { get; set; }
        public int StaffID { get; set; }
        public int RiderID { get; set; }
        public string? ComplaintDesc { get; set; }
        public string? ComplaintStatus {  get; set; }
        public DateTime ComplaintDateTime { get; set; }
    }
}
