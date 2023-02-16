using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClinicManagement.Models
{
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid doctor_id { get; set; }
        public string name { get; set; }
        public string speciality { get; set; }
        public string contact { get; set; }
        public string email { get; set; }
    }
}
