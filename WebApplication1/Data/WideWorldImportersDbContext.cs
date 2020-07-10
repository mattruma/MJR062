using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class WideWorldImportersDbContext : DbContext
    {
        public WideWorldImportersDbContext(
            DbContextOptions<WideWorldImportersDbContext> options) : base(options)
        {
        }

        public DbSet<PeopleData> People { get; set; }
    }
}
