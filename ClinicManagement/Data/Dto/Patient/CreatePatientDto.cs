using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManagement.Data.Dto.Patient
{
    public class CreatePatientDto : BasePatientDto
    {
        [ForeignKey("UserId")]
        public string? UserId { get; set; }
    }
}
