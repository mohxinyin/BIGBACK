using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BIGBACK.Domain;

namespace BIGBACK.Data
{
    public class BIGBACKContext : DbContext
    {
        public BIGBACKContext (DbContextOptions<BIGBACKContext> options)
            : base(options)
        {
        }

        public DbSet<BIGBACK.Domain.BusinessOwner> BusinessOwner { get; set; } = default!;
        public DbSet<BIGBACK.Domain.Business> Business { get; set; } = default!;
        public DbSet<BIGBACK.Domain.Menu> Menu { get; set; } = default!;
        public DbSet<BIGBACK.Domain.MenuItem> MenuItem { get; set; } = default!;
    }
}
