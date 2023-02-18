using ClinicManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicManagement.Data.Configurations
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasData(
            new Appointment
            {
                Id = "app1",
                appointmentDate = "20040706",
                DoctorId="doctor1",
                PatientId="patient1",
                comment ="comments",
                status = "new"

            }, new Appointment
            {
                Id = "app2",
                appointmentDate = "20040706",
                DoctorId = "doctor2",
                PatientId = "patient2",
                comment = "comments",
                status = "new"

            }, new Appointment
            {
                Id = "app3",
                appointmentDate = "20040706",
                DoctorId = "doctor3",
                PatientId = "patient3",
                comment = "comments",
                status = "new"

            });
        }
    }
}
