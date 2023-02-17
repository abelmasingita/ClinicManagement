using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManagement.Models
{
    public class Payment
    {
        public int Id { get; set; }

        [ForeignKey(nameof(AppointmentId))]
        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; }

        public double amount { get; set; }
        public string paymentDate { get; set; }
        public string method { get; set; }
        public string status { get; set; }
    }
}
