using ClinicManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicManagement.Data.Configurations
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasData(
            new Patient
            {
                first_name = "Masingitas",
                last_name = "Hlongwanii",
                contact = "074 226 1505",
                email = "hlongwaniabb@gmail.com",
                dateOfBirth = "20010607",
                gender = "Male",
                Id = "patient1",
                UserId = "user1"

            },
            new Patient
            {
                first_name = "Abel",
                last_name = "Hlongwani",
                contact = "074 226 1505",
                email = "abelmasingita9@gmail.com",
                dateOfBirth = "20010607",
                gender = "Male",
                Id = "patient2",
                UserId = "user2"
            },
            new Patient
            {
                first_name = "Moses",
                last_name = "Hlongwani",
                contact = "074 226 1505",
                email = "abelmasingita9@gmail.com",
                dateOfBirth = "20010607",
                gender = "Male",
                Id = "patient3",
                UserId = "user3"
            });
        }
    }
}
