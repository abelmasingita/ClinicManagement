﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClinicManagement.Models
{
    public class Doctor : BaseModel
    {

        public int Id { get; set; }
        public string speciality { get; set; }
  
    }
}
