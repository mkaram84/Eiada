namespace Eiada.Api.Entities;

public class Radiology
{
    public required int RadiologyId { get; set; } // Primary key
    public required string Name { get; set; } // Analysis name
    public string Description { get; set; } // Brief description
}

