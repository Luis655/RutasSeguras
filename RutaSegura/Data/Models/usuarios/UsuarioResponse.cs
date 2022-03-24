using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Usuario.Data.Model
{
    public partial class UsuarioResponse
    {
        public int Idusuario { get; set; }
        [Required]
        public string? NombreCompleto { get; set; }
        [Required]
        public DateTime FechNac { get; set; }
        [Required]
        public string? Direccion { get; set; }

        public string? genero { get; set; }

        public int Edad(){

            
            var fechaActual = DateTime.Now.Year;
            var edad1 = FechNac.Year;

            var edad = fechaActual -edad1;
            
            return edad;
        }

    }
}