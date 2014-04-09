using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    interface IPerfil
    {
        List<Perfil> selectPerfiles();
        Perfil selectPerfilById(int id);
    }
}
