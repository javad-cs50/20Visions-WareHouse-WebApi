using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WareHouse.Application.Interfaces;
using WareHouse.Domain.Entities.Common;
using WareHouse.Domain.Entities.ScaleTicket;

namespace WareHouse.Infrastructure.ApplicationDb;

public class ApplicationDbContext:DbContext,IApplicationDb
{
    private readonly IHttpContextAccessor _httpContext;
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ,IHttpContextAccessor httpContext ):base(options)
    {
        _httpContext = httpContext;
    }
    public DbSet<ScaleTicket> ScaleTickets => Set<ScaleTicket>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<TEntity> SetDbSet<TEntity>() where TEntity : BaseEntity => Set<TEntity>();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
}

