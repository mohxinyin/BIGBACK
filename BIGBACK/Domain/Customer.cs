namespace BIGBACK.Domain
{
    public class Customer: BaseDomainModel
    {
        public string? CustomerName { get; set; }
        public string? CustomerMobileNumber { get; set; }
        public string? CustomerGender { get; set; }
        public string? CustomerAddress { get; set; }
        public string? CustomerEmail { get; set; }

        // Tracking Fields
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
