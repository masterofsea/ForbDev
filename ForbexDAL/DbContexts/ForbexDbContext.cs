using ForbexDAL.Data;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace ForbexDAL.DbContexts;

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public class ForbexDbContext : DbContext
{
    public ForbexDbContext()
    {
    }
    
    public ForbexDbContext(DbContextOptions<ForbexDbContext> options) : base(options)
    {
    }

    public DbSet<Contract> Contracts { get; set; } = null!;

    public DbSet<Partner> Partners { get; set; } = null!;

    public DbSet<Lessee> Lessees { get; set; } = null!;

    public DbSet<MailContract> MailContracts { get; set; } = null!;

    public DbSet<Correspondence> Correspondences { get; set; } = null!;

    public DbSet<Template> Templates { get; set; } = null!;
}