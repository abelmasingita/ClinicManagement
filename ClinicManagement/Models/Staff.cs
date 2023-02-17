using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClinicManagement.Models
{
    public class Staff : BaseModel
    {
        public string position { get; set; }
    }
}
