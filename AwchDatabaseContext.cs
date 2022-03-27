using Microsoft.EntityFrameworkCore;

namespace Awch.Site;

public class AwchDatabaseContext : DbContext
{
    public DbSet<ImageRecord> ImageRecords { get; set; }

    public AwchDatabaseContext(DbContextOptions<AwchDatabaseContext> options) : base(options)
    {
    }
}