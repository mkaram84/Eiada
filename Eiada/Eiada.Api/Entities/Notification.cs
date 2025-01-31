namespace Eiada.Api.Entities;

public class Notification
{
    public required int NotificationId { get; set; }
    public required int PatientId { get; set; }
    public required int DoctorId { get; set; }
    public required int AdminId { get; set; }
    public required string Message { get; set; }
    public required DateTime DateTime { get; set; }
    public string Status { get; set; } // Sent, Received, Read

    public virtual Patient Patient { get; set; }
    public virtual Doctor Doctor { get; set; }
    public virtual Admin Admin { get; set; }
}