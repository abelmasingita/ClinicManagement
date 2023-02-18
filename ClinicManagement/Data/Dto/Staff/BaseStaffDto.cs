using System.ComponentModel.DataAnnotations;

namespace ClinicManagement.Data.Dto.Staff
{
    public class BaseStaffDto
    {

        public string first_name { get; set; }

        [Required]
        public string last_name { get; set; }

        [Required]
        public string contact { get; set; }

        [Required]
        public string email { get; set; }

        public string position { get; set; }
    }
}
