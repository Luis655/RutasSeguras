using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DireccionesSeguras.Data.Model
{
    public partial class DireccionessegurasCreate
    {
        public int Iddireccionsegura { get; set; }
        public int? Latitud { get; set; }
        public int? Longitud { get; set; }
        public int? Idpeligro { get; set; }

    }
}