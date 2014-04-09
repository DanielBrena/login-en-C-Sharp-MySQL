using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    interface IUsuario
    {
        List<Usuario> selectUsuarios();
        Usuario selectUsuarioById(int id);
        Usuario buscarUsuario(string usuario, string contrasena);
        void agregarUsuario(string nombre, string usuario, string contrasena, int estatus, int perfilID);

    }
}
