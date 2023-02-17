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
                Id = 1,
                UserId = "1"

            },
            new Doctor
            {
                first_name = "Abel",
                last_name = "Hlongwani",
                contact = "074 226 1505",
                email = "abelmasingita9@gmail.com",
                speciality = "Teeth",
                Id = 2,
                UserId = "2"

            },
            new Doctor
            {
                first_name = "Moses",
                last_name = "Hlongwani",
                contact = "074 226 1505",
                email = "abelmasingita9@gmail.com",
                speciality = "Eyes",
                Id = 3,
                UserId = "3"
            });

        }
    }
}
