using Eiada.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eiada.Api;

public class EiadaDbContext(DbContextOptions<EiadaDbContext> options) : DbContext(options)
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Visit> Visits { get; set; }
    public DbSet<Medication> Medications { get; set; }
    public DbSet<Medicine> Medicines { get; set; }
    public DbSet<LabTest> LabTests { get; set; }
    public DbSet<Radiology> Radiologies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Patient>().HasMany(p => p.Appointments).WithOne(a => a.Patient).HasForeignKey(a => a.PatientId);
        modelBuilder.Entity<Patient>().HasMany(p => p.Visits).WithOne(v => v.Patient).HasForeignKey(v => v.PatientId);
        modelBuilder.Entity<Patient>().HasMany(p => p.Payments).WithOne(p => p.Patient).HasForeignKey(p => p.PatientId);
        modelBuilder.Entity<Patient>().HasMany(p => p.Notifications).WithOne(n => n.Patient).HasForeignKey(n => n.PatientId);

        modelBuilder.Entity<Doctor>().HasMany(d => d.Appointments).WithOne(a => a.Doctor).HasForeignKey(a => a.DoctorId);
        modelBuilder.Entity<Doctor>().HasMany(d => d.Visits).WithOne(v => v.Doctor).HasForeignKey(v => v.DoctorId);
        modelBuilder.Entity<Doctor>().HasMany(d => d.Payments).WithOne(p => p.Doctor).HasForeignKey(p => p.DoctorId);
        modelBuilder.Entity<Doctor>().HasMany(d => d.Notifications).WithOne(n => n.Doctor).HasForeignKey(n => n.DoctorId);

        modelBuilder.Entity<Admin>().HasMany(a => a.Notifications).WithOne(n => n.Admin).HasForeignKey(n => n.AdminId);

        modelBuilder.Entity<Visit>().HasMany(v => v.Medications).WithOne(m => m.Visit).HasForeignKey(m => m.VisitId);
        modelBuilder.Entity<Visit>().HasMany(v => v.LabTests);
        modelBuilder.Entity<Visit>().HasMany(v => v.Radiologies);
        modelBuilder.Entity<Medication>().HasOne(m => m.Medicine);
    }
}

