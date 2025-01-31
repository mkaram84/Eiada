namespace Eiada.Api.Entities;

public class Doctor
{
    public required int DoctorId { get; set; }
    public required string Name { get; set; }
    public string Email { get; set; }
    public required string Phone { get; set; }
    public string Specialty { get; set; }
    public string Availability { get; set; } // Can be a more structured type
    public string Qualifications { get; set; }

    public virtual IEnumerable<Appointment> Appointments { get; set; }
    public virtual IEnumerable<Visit> Visits { get; set; }
    public virtual IEnumerable<Payment> Payments { get; set; }
    public virtual IEnumerable<Notification> Notifications { get; set; }
}
