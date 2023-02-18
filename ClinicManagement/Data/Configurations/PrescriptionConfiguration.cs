using ClinicManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicManagement.Data.Configurations
{
    public class PrescriptionConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.HasData(
           new Prescription
           {
               Id = "pre1",
               DoctorId= "doctor1",
               dosage = "1 evening",
               instructions = "prescription instructions",
               medicine = "Flue medicine",
               prescriptiobDate = "20030406",
               PatientId = "patient1"
           }, new Prescription
           {
               Id = "pre2",
               DoctorId = "doctor2",
               dosage = "2 evening",
               instructions = "prescription instructions",
               medicine = "Flue medicine",
               prescriptiobDate = "20030406",
               PatientId = "patient2"
           }, new Prescription
           {
               Id = "pre3",
               DoctorId = "doctor3",
               dosage = "3 evening",
               instructions = "prescription instructions",
               medicine = "Flue medicine",
               prescriptiobDate = "20030406",
               PatientId = "patient3"
           });
        }
    }
}
