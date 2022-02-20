using System;
using System.Collections.Generic;

namespace Policia.Data.Model
{
    public partial class DireccionessegurasResponse
    {
        public int? Latitud { get; set; }
        public int? Longitud { get; set; }
         public string Tipopeligro { get; set; }
        public string Descripcion { get; set; }

    }
}
