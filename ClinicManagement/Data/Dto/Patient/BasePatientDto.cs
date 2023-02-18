using System.ComponentModel.DataAnnotations;

namespace ClinicManagement.Data.Dto.Patient
{
    public class BasePatientDto
    {

        [Required]
        public string first_name { get; set; }

        [Required]
        public string last_name { get; set; }

        [Required]
        public string contact { get; set; }

        [Required]
        public string email { get; set; }
        public string dateOfBirth { get; set; }
        public string gender { get; set; }
    }
}
