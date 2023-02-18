using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManagement.Data.Dto.Payment
{
    public class BasePaymentDto
    {

        [ForeignKey(nameof(AppointmentId))]
        public string AppointmentId { get; set; }

        public double amount { get; set; }
        public string paymentDate { get; set; }
        public string method { get; set; }
        public string status { get; set; }
    }
}
