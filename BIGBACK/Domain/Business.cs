namespace BIGBACK.Domain
{
    public class Business:BaseDomainModel
    {
        public string? BusinessName { get; set; }
        public string? BusinessAddress { get; set; }
        public string? BusinessContact { get; set; }
        public string? BusinessRating { get; set; }
        public string? BusinessStatus { get; set; }
        public int BusinessOwnerId { get; set; }

        // Navigation Property to Business (this is only for object reference, no new column)
        public BusinessOwner? BusinessOwner { get; set; }
    }
}
