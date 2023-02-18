using ClinicManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicManagement.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(
           new ApplicationUser
           {
               first_name = "Admin",
               last_name = "User",
               UserName = "admin@gamil.com",
               Email = "admin@gamil.com",
               PasswordHash = "123456@clinic*",
               Id = "user1"

           }, new ApplicationUser
           {
               first_name = "Admin2",
               last_name = "User2",
               UserName = "admin2@gamil.com",
               Email = "admin2@gamil.com",
               PasswordHash = "123456@clinic*",
               Id = "user2"

           }, new ApplicationUser
           {
               first_name = "Admin3",
               last_name = "User3",
               UserName = "admin3gamil.com",
               Email = "admin3@gamil.com",
               PasswordHash = "123456@clinic*",
               Id = "user3"
           });

        }
    }
}
