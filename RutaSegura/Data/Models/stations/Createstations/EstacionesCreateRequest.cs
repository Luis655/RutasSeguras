using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Estacion.Data.Model
{
    public partial class EstacionesCreateRequest
    {
        [Required]
        public int idestacion {get; set;}
        [Required]
        public string? Nombreestacion { get; set; }
        [Required]
        public string? Estado { get; set; }
        [Required]
        public string? Municipio { get; set; }
        [Required]
        public string? Colonia { get; set; }
        [Required]
        public string? Calle { get; set; }
        [Required]
        public string? Cruzamientos { get; set; }
        
    }

}