using ClinicManagement.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManagement.Data.Dto.Doctor
{
    public class CreateDoctorDto : BaseDoctorDto
    {

        [ForeignKey("UserId")]
        public string? UserId { get; set; }
    }
}
