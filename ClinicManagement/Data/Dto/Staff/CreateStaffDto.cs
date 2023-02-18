using ClinicManagement.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManagement.Data.Dto.Staff
{
    public class CreateStaffDto : BaseStaffDto
    {
      

        [ForeignKey("UserId")]
        public string? UserId { get; set; }

    }
}
