using ClinicManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicManagement.Data.Configurations
{
    public class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
            new Staff
            {
                first_name = "Masingitaaa",
                last_name = "Hlongwani",
                contact = "074 226 1505",
                email = "hlongwaniab@gmail.com",
                position = "Nurse",
                Id = 1,
                UserId = "1"

            },
            new Staff
            {
                first_name = "Abelll",
                last_name = "Hlongwani",
                contact = "074 226 1505",
                email = "abelmasingita9@gmail.com",
                position = "Nurse",
                Id = 2,
                UserId = "2"
            },
            new Staff
            {
                first_name = "Mosesss",
                last_name = "Hlongwani",
                contact = "074 226 1505",
                email = "abelmasingita9@gmail.com",
                position = "Nurse",
                Id = 3,
                UserId = "3"
            });
        }
    }
}
