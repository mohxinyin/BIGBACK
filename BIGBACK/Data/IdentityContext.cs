using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BIGBACK.Data;

namespace BIGBACK.Data
{
    public class IdentityContext(DbContextOptions<IdentityContext> options) : IdentityDbContext<BIGBACKUser>(options)
    {
    }
}
