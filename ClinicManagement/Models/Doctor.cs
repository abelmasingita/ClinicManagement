using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClinicManagement.Models
{
    public class Doctor : BaseModel
    {

        public string speciality { get; set; }
  
    }
}
