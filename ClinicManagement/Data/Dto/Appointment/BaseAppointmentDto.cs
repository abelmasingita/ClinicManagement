using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManagement.Data.Dto.Appointment
{
    public class BaseAppointmentDto
    {
        public string appointmentDate { get; set; }
        public string status { get; set; }
        public string comment { get; set; }

        [ForeignKey(nameof(PatientId))]
        public string PatientId { get; set; }

        [ForeignKey(nameof(DoctorId))]
        public string DoctorId { get; set; }
    }
}
