using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DireccionesSeguras.Data.Model
{
    public partial class CategoriaPeligro
    {
        public int Idpeligro { get; set; }
        public string Tipopeligro { get; set; }
        public string Descripcion { get; set; }

    }
}