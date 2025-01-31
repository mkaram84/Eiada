namespace Eiada.Api.Entities;

public class Visit
{
    public required int VisitId { get; set; }
    public required int PatientId { get; set; }
    public required int DoctorId { get; set; }
    public required DateTime DateOfVisit { get; set; }
    public required string Diagnosis { get; set; }
    public required string Treatment { get; set; }

    public virtual IEnumerable<Medication> Medications { get; set; }
    public virtual IEnumerable<LabTest> LabTests { get; set; }
    public virtual IEnumerable<Radiology> Radiologies { get; set; }

    public virtual Patient Patient { get; set; }
    public virtual Doctor Doctor { get; set; }
}
