namespace Eiada.Api.Entities;

public class Patient
{
    public required int PatientId { get; set; }
    public required string Name { get; set; }
    public string Email { get; set; }
    public required string Phone { get; set; }
    public required DateTime DateOfBirth { get; set; }
    public string MedicalHistory { get; set; }
    public string InsuranceInfo { get; set; }

    public virtual IEnumerable<Appointment> Appointments { get; set; }
    public virtual IEnumerable<Visit> Visits { get; set; }
    public virtual IEnumerable<Payment> Payments { get; set; }
    public virtual IEnumerable<Notification> Notifications { get; set; }
}
