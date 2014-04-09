using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace ConsoleApplication15
{
    class PerfilDAO: IPerfil
    {

        public List<Perfil> selectPerfiles()
        {
            DataSource ds = new DataSource();
            DataTable dt = ds.ejecutarConsulta("SELECT * FROM perfil");

            List<Perfil> perfiles = new List<Perfil>();
            Perfil perfil = null;
            
            foreach (DataRow registro in dt.Rows)
            {
                perfil = new Perfil();
                perfil.id = int.Parse(registro["id"].ToString());
                perfil.nombre = registro["nombre"].ToString();
                perfil.descripcion = registro["descripcion"].ToString();
                perfil.estatus = int.Parse(registro["estatus"].ToString());
                perfiles.Add(perfil);
            }
            return perfiles;

        }

        public Perfil selectPerfilById(int id)
        {
            DataSource ds = new DataSource();
            DataTable dt = ds.ejecutarConsulta("SELECT * FROM perfil where id="+id);
            Perfil perfil = new Perfil();

            foreach (DataRow registro in dt.Rows)
            {
                perfil.id = int.Parse(registro["id"].ToString());
                perfil.nombre = registro["nombre"].ToString();
                perfil.descripcion = registro["descripcion"].ToString();
                perfil.estatus = int.Parse(registro["estatus"].ToString());
            }

            return perfil;
        }
    }
}
