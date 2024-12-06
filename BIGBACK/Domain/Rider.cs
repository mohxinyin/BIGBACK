namespace BIGBACK.Domain
{
    public class Rider : BaseDomainModel
    {
        public int RiderID { get; set; }
        public string? RiderName { get; set; }
        public string? RiderContact { get; set; }
        public double RiderRating { get; set; }
    }
}
