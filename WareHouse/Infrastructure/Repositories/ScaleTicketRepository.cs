using WareHouse.Application.Interfaces.Repositories;
using WareHouse.Domain.Entities.ScaleTicket;
using WareHouse.Domain.Enums;
using WareHouse.Infrastructure.ApplicationDb;

namespace WareHouse.Infrastructure.Repositories;

public class ScaleTicketRepository: IScaleTicketRepository
{
    private readonly ApplicationDbContext _context;
    public ScaleTicketRepository(ApplicationDbContext context )
    {
        _context = context;
    }

    
    public async Task<ScaleTicket> GetById(int id)
    {
        var scaleTicket =await _context.ScaleTickets.FindAsync(id);        
        
        return scaleTicket;
    }

    public async Task<bool> Create(ScaleTicket scaleTicket)
    {
        await _context.ScaleTickets.AddAsync(scaleTicket);
        var changes = await _context.SaveChangesAsync();
        if (changes > 0) return true;
        return false;
    }
    public async Task<bool> Update(ScaleTicket scaleTicket)
    {
         _context.ScaleTickets.Update(scaleTicket);
        var changes = await _context.SaveChangesAsync();
        if (changes > 0) return true;
        return false;
    }
    public async Task<bool> Delete(int id)
    {
        var scaleTicket = await _context.ScaleTickets.FindAsync(id);
        if(scaleTicket != null)
        {
            scaleTicket.AppAction = AppAction.Deleted;
            var changes =await _context.SaveChangesAsync();
            if (changes > 0)
                return true;
            else
                return false;
        }
        return false;
        
    }
}
