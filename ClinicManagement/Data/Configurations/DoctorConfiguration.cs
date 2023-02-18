using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ClinicManagement.Models;

namespace ClinicManagement.Data.Configurations
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasData(
            new Doctor
            {
                first_name = "Masingita",
                last_name = "Hlongwani",
                contact = "074 226 1505",
                email = "hlongwaniab@gmail.com",
                speciality = "Children",
                Id = "doctor1",
                UserId = "user1"

            },
            new Doctor
            {
                first_name = "Abel",
                last_name = "Hlongwani",
                contact = "074 226 1505",
                email = "abelmasingita9@gmail.com",
                speciality = "Teeth",
                Id = "doctor2",
                UserId = "user2"

            },
            new Doctor
            {
                first_name = "Moses",
                last_name = "Hlongwani",
                contact = "074 226 1505",
                email = "abelmasingita9@gmail.com",
                speciality = "Eyes",
                Id = "doctor3",
                UserId = "user3"
            });

        }
    }
}
