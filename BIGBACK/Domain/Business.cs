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



        public BusinessOwner? BusinessOwner { get; set; }
    }
}
