using WareHouse.Domain.Entities.ScaleTicket;

namespace WareHouse.Application.Interfaces.Repositories
{
    public interface IScaleTicketRepository
    {
        Task<ScaleTicket> GetById(int id);
        Task<bool> Create(ScaleTicket scaleTicket);
        Task<bool> Update(ScaleTicket scaleTicket);
        Task<bool> Delete(int id);
    }
}
