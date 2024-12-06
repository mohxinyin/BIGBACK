using System.Globalization;

namespace BIGBACK.Domain
{
    public class Staff : BaseDomainModel
    {
        public int StaffID { get; set; }
        public string? StaffName { get; set; }
        public string? StaffEmail { get; set; }
        public string? StaffContact { get; set; }
    }
}
