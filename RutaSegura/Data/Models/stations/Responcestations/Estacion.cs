using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Estacion.Data.Model
{
    public partial class Estacion
    {
        [Required]
        public int Idestacion { get; set; }
        [Required]
        public string? Nombreestacion { get; set; }
        [Required]
        public string? Direccion { get; set; }
        
    }
}