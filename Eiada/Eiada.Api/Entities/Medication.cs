namespace Eiada.Api.Entities;

public class Medication
{
    public required int MedicationId { get; set; }
    public required int VisitId { get; set; }
    public required Medicine Medicine { get; set; }
    public int Quantity { get; set; }
    public int DurationInDays { get; set; }
    public string Instructions { get; set; }
    public virtual Visit Visit { get; set; }
}
