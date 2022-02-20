using System;
using System.Collections.Generic;

namespace Policia.Data.Model
{
    public partial class Genero
    {
        public Genero()
        {
            Policia = new HashSet<Policia>();
           
        }

        public int Idgenero { get; set; }
        public string Tipigenero { get; set; }

        public virtual ICollection<Policia> Policia { get; set; }
        
    }
}
