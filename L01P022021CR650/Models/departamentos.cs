﻿using System.ComponentModel.DataAnnotations;

namespace L01P022021CR650.Models
{
    public class departamentos
    {
        [Key]
        [Display(Name = "ID del Departamento")]
        public int id { get; set; }
        [Display(Name = "Departamento")]
        public string? departamento { get; set; }
    }
}
