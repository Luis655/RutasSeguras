using System;
using System.Collections.Generic;

namespace Policia.Data.Model
{
    public partial class Estacion
    {
        public Estacion()
        {
            Policia = new HashSet<Policia>();
        }

        public int Idestacion { get; set; }
        public string? Nombreestacion { get; set; }
        public int? Iddireccion { get; set; }
        public virtual ICollection<Policia> Policia { get; set; }
        
    }
}
