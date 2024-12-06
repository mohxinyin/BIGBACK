namespace BIGBACK.Domain
{
    public class Business:BaseDomainModel
    {
        public string? BusinessName { get; set; }
        public string? BusinessAddress { get; set; }
        public string? BusinessContact { get; set; }
        public string? BusinessRating { get; set; }
        public int BusinessStatus { get; set; }
    }
}
