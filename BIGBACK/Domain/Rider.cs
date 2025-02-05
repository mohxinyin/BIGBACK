namespace BIGBACK.Domain
{
    public class Rider : BaseDomainModel
    {
        public string? RiderName { get; set; }
        public string? RiderContact { get; set; }
        public double RiderRating { get; set; }

        // Tracking Fields
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
