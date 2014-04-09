using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    class Perfil
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int estatus { get; set; }

        public override  string ToString()
        {
            return id + " " + nombre + " " + descripcion + " " + estatus;
        }
    }
}
