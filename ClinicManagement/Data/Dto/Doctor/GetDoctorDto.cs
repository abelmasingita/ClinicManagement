﻿using ClinicManagement.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManagement.Data.Dto.Doctor
{
    public class GetDoctorDto : BaseDoctorDto
    {
        public int Id { get; set; }
        [ForeignKey("UserId")]
        public string? UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
