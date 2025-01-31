namespace Eiada.Api.Entities;

public class LabTest 
{
    public required int LabTestId { get; set; } // Primary key
    public required string Name { get; set; } // Analysis name
    public string Description { get; set; } // Brief description
}

