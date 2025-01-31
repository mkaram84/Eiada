namespace Eiada.Api.Entities;

public class Payment
{
    public required int PaymentId { get; set; }
    public required int PatientId { get; set; }
    public required int DoctorId { get; set; }
    public required decimal Amount { get; set; }
    public required DateTime PaymentDate { get; set; }
    public string PaymentMethod { get; set; } // Credit Card, Insurance, Cash
    public string Status { get; set; } // Pending, Completed, Refunded

    public virtual Patient Patient { get; set; }
    public virtual Doctor Doctor { get; set; } // Optional relation if needed
}
