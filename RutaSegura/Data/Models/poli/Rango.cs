using System;
using System.Collections.Generic;

namespace Policia.Data.Model
{
    public partial class Rango
    {
        public Rango()
        {
            Policia = new HashSet<Policia>();
        }

        public int Idrango { get; set; }
        public string Tipoderango { get; set; }

        public virtual ICollection<Policia> Policia { get; set; }
    }
}
