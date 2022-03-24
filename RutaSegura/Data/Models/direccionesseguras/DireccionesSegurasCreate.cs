using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DireccionesSeguras.Data.Model
{
    public partial class DireccionessegurasCreate
    {
        public int Iddireccionsegura { get; set; }
        public string? Latitud { get; set; }
        public string? Longitud { get; set; }
        public int? Idpeligro { get; set; }

    }
}