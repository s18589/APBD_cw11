using APBD_cw11.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_cw11.Database
{
    public class ClinicDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<PrescrtiptionMedicament> PrescrtiptionMedicaments { get; set; }

        public ClinicDbContext(){}

        public ClinicDbContext(DbContextOptions options):base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PrescrtiptionMedicament>().HasKey(p => new { p.IdPrescription, p.IdMedicament });

            modelBuilder.Entity<PrescrtiptionMedicament>().HasOne<Prescription>(p => p.Prescription)
                .WithMany(p => p.PrescrtiptionMedicament)
                .HasForeignKey(p => p.IdPrescription);

            modelBuilder.Entity<PrescrtiptionMedicament>().HasOne<Medicament>(m => m.Medicament)
                .WithMany(m => m.PrescrtiptionMedicament)
                .HasForeignKey(m => m.IdMedicament);

            var doctorList = new List<Doctor>();
            doctorList.Add(new Doctor { Id = 1, FirstName = "AAA", Email = "AAA@email.com", LastName = "AAA" });
            doctorList.Add(new Doctor { Id = 2, FirstName = "BBB", Email = "BBB@email.com", LastName = "BBB" });

            modelBuilder.Entity<Doctor>().HasData(doctorList);

            var patientList = new List<Patient>();
            patientList.Add(new Patient { Id = 1, FirstName = "AAA", LastName = "BBB", BirthDate = DateTime.Now });

            modelBuilder.Entity<Patient>().HasData(patientList);

            var medicamentList = new List<Medicament>();
            medicamentList.Add(new Medicament { Id = 1, Name = "acodin", Description = "fajny", Type = "potezny" });
            medicamentList.Add(new Medicament { Id = 2, Name = "rutinoscorbin", Description = "na przeziebienie", Type = "bez recepty" });

            modelBuilder.Entity<Medicament>().HasData(medicamentList);

            var prescriptionList = new List<Prescription>();
            prescriptionList.Add(new Prescription { Id = 1, Date = DateTime.Now, DueDate = DateTime.Now, IdDoctor = 1, IdPatient = 1 });
            prescriptionList.Add(new Prescription { Id = 2, Date = DateTime.Now, DueDate = DateTime.Now, IdDoctor = 2, IdPatient = 1 });

            modelBuilder.Entity<Prescription>().HasData(prescriptionList);

            var prescriptionmedicamentList = new List<PrescrtiptionMedicament>();
            prescriptionmedicamentList.Add(new PrescrtiptionMedicament { IdMedicament = 1, IdPrescription = 1, Dose = 10, Details = "xxx" });
            prescriptionmedicamentList.Add(new PrescrtiptionMedicament { IdMedicament = 2, IdPrescription = 1, Dose = 20, Details = "yyy" });
            prescriptionmedicamentList.Add(new PrescrtiptionMedicament { IdMedicament = 1, IdPrescription = 2, Dose = 1, Details = "ccc" });

            modelBuilder.Entity<PrescrtiptionMedicament>().HasData(prescriptionmedicamentList);
        }
    }
}
