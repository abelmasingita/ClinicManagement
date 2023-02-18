using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManagement.Data.Dto.Patient
{
    public class PatientDto : BasePatientDto
    {
        public int Id { get; set; }

        [ForeignKey("UserId")]
        public string? UserId { get; set; }
    }
}
