using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Estacion.Data.Model
{
    public partial class Direccione
    {
        public Direccione()
        {
            Estacions = new HashSet<Estacion>();
        }
        [Required]
        public int Iddireccion { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public string Municipio { get; set; }
        [Required]
        public string Colonia { get; set; }
        [Required]
        public string Calle { get; set; }
        [Required]
        public string Cruzamientos { get; set; }

        public virtual ICollection<Estacion> Estacions { get; set; }
    }
}
