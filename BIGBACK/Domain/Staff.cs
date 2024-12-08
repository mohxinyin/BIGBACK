using System.Globalization;

namespace BIGBACK.Domain
{
    public class Staff : BaseDomainModel
    {
        public string? StaffName { get; set; }
        public string? StaffEmail { get; set; }
        public string? StaffContact { get; set; }
    }
}
 