using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    //DTO
    class Usuario
    {
        public int id { set; get; }
        public string nombre {set;get;}
        public string usuario {set;get;}
        public string contrasena { set; get; }
        public int estatus { set; get; }
        public Perfil perfil_id { set; get; }

    }
}
