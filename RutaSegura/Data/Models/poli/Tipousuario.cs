using System;
using System.Collections.Generic;

namespace Policia.Data.Model
{
    public partial class Tipousuario
    {
        public Tipousuario()
        {
            Policia = new HashSet<Policia>();
            
        }

        public int Idtipousuario { get; set; }
        public int? Idcargo { get; set; } =1;
        public string Correo { get; set; }
        public string Contraseña { get; set; }

        
        public virtual ICollection<Policia> Policia { get; set; }
        
    }
}
