using System;
using System.Collections.Generic;

namespace Policia.Data.Model
{
public partial class PoliciaCreateRequest
    {
        
        public int Idpolicias{get; set;}
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public int? Edad { get; set; }
        public int? Numeroplaca { get; set; }
        public int? Idrango { get; set; }
        public int? Idestacion { get; set; }
        public int? Idcargo { get; set; } =1;
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public int? idgenero { get; set; }

        /*public virtual Estacion IdestacionNavigation { get; set; }
        public virtual Genero IdgeneroNavigation { get; set; }
        public virtual Rango IdrangoNavigation { get; set; }*/



    }
        
    
}