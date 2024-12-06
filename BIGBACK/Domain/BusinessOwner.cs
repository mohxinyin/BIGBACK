using Microsoft.AspNetCore.Identity;

namespace BIGBACK.Domain
{
    public class BusinessOwner : BaseDomainModel
    {
        public string? BusinessOwnerName { get; set; }
        public string? BusinessOwnerrContact {  get; set; }
        public string?  BusinessOwnerEmail { get; set; }
        public string? BusinessOwnerGender { get; set; }

    }
}
