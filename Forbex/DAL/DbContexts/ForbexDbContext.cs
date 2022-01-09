using Forbex.DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace Forbex.DAL.DbContexts
{
    public class ForbexDbContext : DbContext
    {
        public ForbexDbContext(DbContextOptions<ForbexDbContext> options) : base(options)
        {
        }

        public DbSet<Contract> Contracts { get; set; }
    }
}