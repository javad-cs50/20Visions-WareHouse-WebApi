using Microsoft.AspNetCore.Mvc.ApplicationParts;
using WareHouse.Domain.Enums;

namespace WareHouse.Domain.Entities.Common;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime ModifiedAt { get; set; }
    public string ModifiedBy { get; set; } = string.Empty;
    public AppAction AppAction { get; set; }
}
