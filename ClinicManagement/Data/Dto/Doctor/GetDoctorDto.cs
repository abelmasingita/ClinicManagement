using ClinicManagement.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManagement.Data.Dto.Doctor
{
    public class GetDoctorDto
    {
        public int Id { get; set; }
        [Required]
        public string first_name { get; set; }

        [Required]
        public string last_name { get; set; }

        [Required]
        public string contact { get; set; }

        [Required]
        public string email { get; set; }

        public string speciality { get; set; }

        public string? UserId { get; set; }
    }
}
