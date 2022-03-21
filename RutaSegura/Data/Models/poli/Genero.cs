using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Policia.Data.Model
{
    public partial class Genero
    {
        public Genero()
        {
            Policia = new HashSet<Policia>();
           
        }
        [Required]
        public int Idgenero { get; set; }
        [Required]
        public string Tipigenero { get; set; }
        [Required]
        public virtual ICollection<Policia> Policia { get; set; }
        
    }
}
