namespace Eiada.Api.Entities;

public class Appointment
{
    public required int AppointmentId { get; set; }
    public required int PatientId { get; set; }
    public required int DoctorId { get; set; }
    public required DateTime DateTime { get; set; }
    public required string Status { get; set; } // Scheduled, Completed, Canceled
    public string Notes { get; set; }
           
    public virtual Patient Patient { get; set; }
    public virtual Doctor Doctor { get; set; }
}
