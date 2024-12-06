using Microsoft.AspNetCore.Identity;

namespace BIGBACK.Domain
{
    public class BusinessOwner : BaseDomainModel
    {
        public int BusinessOwnerId { get; set; }
        public string? BusinessOwnerName { get; set; }
        public string? BusinessOwnerrContact {  get; set; }
        public string?  BusinessOwnerEmail { get; set; }
        public string? BusinessOwnerGender { get; set; }

    }
}
