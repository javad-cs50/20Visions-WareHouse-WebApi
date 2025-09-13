using WareHouse.Domain.Entities.Common;

namespace WareHouse.Domain.Entities.ScaleTicket;

public class ScaleTicket:BaseEntity
{
    public string ReceiptNumber { get; set; } = string.Empty;
    public string VehicleType { get; set; } = string.Empty;
    public string PlateNumber { get; set; } = string.Empty;
    public decimal WeightFull { get; set; }
    public decimal WeightEmpty { get; set; }
    public decimal WeightNet => WeightFull - WeightEmpty;
    public DateTime Date { get; set; }
    public decimal Price { get; set; }
}
