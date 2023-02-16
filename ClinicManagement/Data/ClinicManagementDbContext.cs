using ClinicManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicManagement.Data
{
    public class ClinicManagementDbContext : DbContext
    {
        public ClinicManagementDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }

        public DbSet<Staff> Staffs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Doctor>().HasData(
            new Doctor
            {
                first_name = "Masingita",
                last_name = "Hlongwani",
                contact = "074 226 1505",
                email = "hlongwaniab@gmail.com",
                speciality = "Children",
                Id = 1

            },
            new Doctor
            {
                first_name = "Abel",
                last_name = "Hlongwani",
                contact = "074 226 1505",
                email = "abelmasingita9@gmail.com",
                speciality = "Teeth",
                Id = 2

            },
            new Doctor
            {
                first_name = "Moses",
                last_name = "Hlongwani",
                contact = "074 226 1505",
                email = "abelmasingita9@gmail.com",
                speciality = "Eyes",
                Id = 3
            });


            modelBuilder.Entity<Patient>().HasData(
            new Patient
            {
                first_name = "Masingitas",
                last_name = "Hlongwanii",
                contact = "074 226 1505",
                email = "hlongwaniabb@gmail.com",
                dateOfBirth = "20010607",
                gender = "Male",
                Id = 1

            },
            new Patient
            {
                first_name = "Abel",
                last_name = "Hlongwani",
                contact = "074 226 1505",
                email = "abelmasingita9@gmail.com",
                dateOfBirth = "20010607",
                gender = "Male",
                Id = 2
            },
            new Patient
            {
                first_name = "Moses",
                last_name = "Hlongwani",
                contact = "074 226 1505",
                email = "abelmasingita9@gmail.com",
                dateOfBirth = "20010607",
                gender = "Male",
                Id = 3
            });

            modelBuilder.Entity<Staff>().HasData(
            new Staff
            {
                first_name = "Masingitaaa",
                last_name = "Hlongwani",
                contact = "074 226 1505",
                email = "hlongwaniab@gmail.com",
                position = "Nurse",
                Id = 1

            },
            new Staff
            {
                first_name = "Abelll",
                last_name = "Hlongwani",
                contact = "074 226 1505",
                email = "abelmasingita9@gmail.com",
                position = "Nurse",
                Id = 2
            },
            new Staff
            {
                first_name = "Mosesss",
                last_name = "Hlongwani",
                contact = "074 226 1505",
                email = "abelmasingita9@gmail.com",
                position = "Nurse",
                Id = 3
            });

        }
    }
}
