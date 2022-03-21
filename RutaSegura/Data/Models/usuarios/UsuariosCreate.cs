using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Usuario.Data.Model
{
    public partial class UsuariosCreate
    {
        public int Idusuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int? Edad { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string Cruzamientos { get; set; }

    }
}