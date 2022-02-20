using System;
using System.Collections.Generic;

namespace Policia.Data.Model
{
    public partial class Policia
    {
         public int Idpolicias { get; set; }
        public string? NombreCompleto { get; set; }
        public int? Edad { get; set; }
        public int? Numeroplaca { get; set; }
        public string? Tipoderango { get; set; }
        public string? Nombreestacion{ get; set; }
        public string? Direccion { get; set; }
        

    }
}