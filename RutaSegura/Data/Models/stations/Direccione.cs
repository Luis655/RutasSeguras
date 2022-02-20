using System;
using System.Collections.Generic;

namespace Estacion.Data.Model
{
    public partial class Direccione
    {
        public Direccione()
        {
            Estacions = new HashSet<Estacion>();
        }

        public int Iddireccion { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string Cruzamientos { get; set; }

        public virtual ICollection<Estacion> Estacions { get; set; }
    }
}
