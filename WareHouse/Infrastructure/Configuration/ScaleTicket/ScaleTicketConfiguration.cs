using Microsoft.EntityFrameworkCore;
using WareHouse.Domain.Entities.ScaleTicket;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WareHouse.Infrastructure.Configuration.ScaleTicketConfiguration;

public class ScaleTicketConfiguration : IEntityTypeConfiguration<ScaleTicket>
{
    public void Configure(EntityTypeBuilder<ScaleTicket> builder)
    {
        builder.HasKey(st => st.Id);
    }
}
