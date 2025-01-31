namespace Eiada.Api.Entities;

public class Medicine
{
    public required int MedicineId { get; set; } // Primary key
    public required string Name { get; set; } // Medicine name
    public required string Description { get; set; } // Brief description
    public string DosageForms { get; set; } // e.g., tablet, liquid
    public string SideEffects { get; set; } // Common side effects
    public string Manufacturer { get; set; } // Manufacturer name
}