using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Awch.Site;

public class AwchDatabaseContext : IdentityDbContext<IdentityUser>
{
    public DbSet<ImageRecord> ImageRecords { get; set; }

    public AwchDatabaseContext(DbContextOptions<AwchDatabaseContext> options) : base(options)
    {
    }
}