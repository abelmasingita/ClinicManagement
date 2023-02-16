using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClinicManagement.Models
{
    public class Staff : BaseModel
    {

        public int Id { get; set; }
        public string position { get; set; }
    }
}
