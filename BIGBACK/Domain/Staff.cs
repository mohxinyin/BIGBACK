using System.Globalization;

namespace BIGBACK.Domain
{
    public class Staff : BaseDomainModel
    {
        public string? StaffName { get; set; }
        public string? StaffEmail { get; set; }
        public string? StaffContact { get; set; }

        // Tracking Fields
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
 