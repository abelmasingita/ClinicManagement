using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManagement.Data.Dto.Prescription
{
    public class BasePrescriptionDto
    {   

        [ForeignKey(nameof(PatientId))]
        public string PatientId { get; set; }
  
        [ForeignKey(nameof(DoctorId))]
        public string DoctorId { get; set; }
    
        public string prescriptiobDate { get; set; }
        public string medicine { get; set; }
        public string dosage { get; set; }
        public string instructions { get; set; }
    }
}
