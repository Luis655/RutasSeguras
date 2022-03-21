using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Policia.Data.Model
{
public partial class PoliciaCreateRequest
    {
        int maximo = 20;
        [Required]
        public int Idpolicias{get; set;}
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? Apellidos { get; set; }
        [Required]
        public int? Edad { get; set; }
        [Required]
        public int? Numeroplaca { get; set; }
        [Required]
        public int? Idrango { get; set; }
        [Required]
        public int? Idestacion { get; set; }
        [Required]
        public int? Idcargo { get; set; } =1;
        [Required]
        public string? Correo { get; set; }
        [Required]
        public string? Contraseña { get; set; }
        [Required]
        public int? idgenero { get; set; }

    }
        
    
}