using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User.Data
{
    public class User
    {
        public string correo { get; set; } 
        public string contraseña { get; set; } 
        public string cargo { get; set; }
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    
      
    }

   
}