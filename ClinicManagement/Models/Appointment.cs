using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManagement.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string appointmentDate { get; set; }
        public string status { get; set; }
        public string comment { get; set; }

        [ForeignKey(nameof(PatientId))]
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        [ForeignKey(nameof(DoctorId))]
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
