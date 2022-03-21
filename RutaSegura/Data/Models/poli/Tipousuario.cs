using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Policia.Data.Model
{
    public partial class Tipousuario
    {
        public Tipousuario()
        {
            Policia = new HashSet<Policia>();
            
        }
        [Required]
        public int? Idtipousuario { get; set; }
        [Required]
        public int? Idcargo { get; set; } =1;
        [Required]
        public string? Correo { get; set; }
        [Required]
        public string? Contraseña { get; set; }

        
        public virtual ICollection<Policia> Policia { get; set; }
        
    }
}
