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
        public int? Edad { get; set; }
        [Required]
        public string? Direccion { get; set; }

        //public int? idgenero { get; set; }

        

    }
}