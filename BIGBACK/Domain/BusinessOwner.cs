using BIGBACK.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BIGBACK.Domain
{
    public class BusinessOwner : BaseDomainModel
    {
        public string? BusinessOwnerName { get; set; }
        public string? BusinessOwnerrContact {  get; set; }
        public string?  BusinessOwnerEmail { get; set; }
        public string? BusinessOwnerGender { get; set; }

        // Tracking Fields
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }


    }
}
