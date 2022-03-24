using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Policia.Data.Model
{
    public partial class Policia
    {
        [Required]
        public int Idpolicias { get; set; }
        [Required]
        public string? NombreCompleto { get; set; }
        [Required]
        public DateTime FechNac { get; set; }
        [Required]
        public int? Numeroplaca { get; set; }
        [Required]
        public string? Tipoderango { get; set; }
        [Required]
        public string? Nombreestacion{ get; set; }
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