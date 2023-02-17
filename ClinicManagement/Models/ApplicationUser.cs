using Microsoft.AspNetCore.Identity;

namespace ClinicManagement.Models
{
    public class ApplicationUser : IdentityUser
    {

        public string first_name { get; set; }
        public string last_name { get; set; }

        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }

        public Staff Staff { get; set; }
    }
}
