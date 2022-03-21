using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DireccionesSeguras.Data.Model
{
    public partial class DireccionessegurasResponse
    {
        public int  Iddireccionsegura { get; set; }
        [Required]
        public int? Latitud { get; set; }
         [Required]
        public int? Longitud { get; set; }
         [Required]
         public string? Tipopeligro { get; set; }
          [Required]
        public string? Descripcion { get; set; }

    }
}
