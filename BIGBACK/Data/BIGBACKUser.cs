using Microsoft.AspNetCore.Identity;

namespace BIGBACK.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class BIGBACKUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
