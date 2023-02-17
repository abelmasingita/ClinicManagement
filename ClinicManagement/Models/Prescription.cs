using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManagement.Models
{
    public class Prescription
    {
        public int Id { get; set; }

        [ForeignKey(nameof(PatientId))]
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        [ForeignKey(nameof(DoctorId))]
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public string prescriptiobDate { get; set; }
        public string medicine { get; set; }
        public string dosage { get; set; }
        public string instructions { get; set; }
    }
}
