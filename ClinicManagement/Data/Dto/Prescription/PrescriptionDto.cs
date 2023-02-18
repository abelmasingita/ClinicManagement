using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManagement.Data.Dto.Prescription
{
    public class PrescriptionDto : BasePrescriptionDto
    {
        public string Id { get; set; }
    }
}
