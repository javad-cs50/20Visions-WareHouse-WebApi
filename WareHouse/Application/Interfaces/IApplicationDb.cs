using Microsoft.EntityFrameworkCore;
using WareHouse.Domain.Entities.Common;
using WareHouse.Domain.Entities.ScaleTicket;

namespace WareHouse.Application.Interfaces;

public interface IApplicationDb
{
    public DbSet<ScaleTicket> ScaleTickets { get; }
    public DbSet<TEntity> SetDbSet<TEntity>() where TEntity : BaseEntity;
}
