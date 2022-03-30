using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DireccionesSeguras.Data.Model
{
    public partial class DireccionessegurasResponse
    {
        public int  Iddireccionsegura { get; set; }
        [Required]
        public string? Latitud { get; set; }
         [Required]
        public string? Longitud { get; set; }
         [Required]
         public string? Tipopeligro { get; set; }
          [Required]

        public Boolean Verificacion { get; set; }
        public string? Descripcion { get; set; }

    }
}
