using System.ComponentModel.DataAnnotations;

namespace ClinicManagement.Models
{
    public class BaseModel
    {
        public string Id { get; set; }
        [Required]
        public string first_name { get; set; }

        [Required]
        public string last_name { get; set; }

        [Required]
        public string contact { get; set; }

        [Required]
        public string email { get; set; }
    }
}
