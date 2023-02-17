using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClinicManagement.Models
{
    public class Patient : BaseModel
    {

        public string dateOfBirth { get; set; }
        public string gender { get; set; }

    }
}
