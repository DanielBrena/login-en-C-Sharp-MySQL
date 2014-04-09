using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace ConsoleApplication15
{
    class UsuarioDAO :IUsuario
    {
    
        public List<Usuario> selectUsuarios()
        {
            DataSource ds = new DataSource();
            DataTable dt =  ds.ejecutarConsulta("SELECT * FROM usuario");

            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario = null;

            foreach (DataRow registro in dt.Rows)
            {
                usuario = new Usuario();
                usuario.id = int.Parse(registro["id"].ToString());
                usuario.nombre = registro["nombre"].ToString();
                usuario.usuario = registro["usuario"].ToString();
                usuario.contrasena = registro["contrasena"].ToString();
                usuario.estatus = int.Parse(registro["estatus"].ToString());
                PerfilDAO perfilDAO = new PerfilDAO();
                usuario.perfil_id = perfilDAO.selectPerfilById(int.Parse(registro["perfil_id"].ToString()));
                usuarios.Add(usuario);
            }
            return usuarios;

        }

        public Usuario selectUsuarioById(int id)
        {
            DataSource ds = new DataSource();
            DataTable dt = ds.ejecutarConsulta("SELECT * from usuario where id=" + id);

            Usuario usuario = new Usuario();
            foreach (DataRow registro in dt.Rows)
            {
                usuario.id = int.Parse(registro["id"].ToString());
                usuario.nombre = registro["nombre"].ToString();
                usuario.usuario = registro["usuario"].ToString();
                usuario.contrasena = registro["contrasena"].ToString();
                usuario.estatus = int.Parse(registro["estatus"].ToString());
                PerfilDAO perfilDAO = new PerfilDAO();
                usuario.perfil_id = perfilDAO.selectPerfilById(int.Parse(registro["perfil_id"].ToString()));
            }

            return usuario;
        }




        public Usuario buscarUsuario(string usuario, string contrasena)
        {
            DataSource ds = new DataSource();
            string sql = "SELECT * FROM usuario WHERE usuario = '" + usuario + "' AND contrasena = '" +
                contrasena + "'";
            DataTable dt = ds.ejecutarConsulta(sql);
            Usuario usuarioOBJ = null;
            if (dt.Rows.Count == 1)
            {
                foreach (DataRow registro in dt.Rows)
                {
                    usuarioOBJ = new Usuario();
                    usuarioOBJ.id = int.Parse(registro["id"].ToString());
                    usuarioOBJ.nombre = registro["nombre"].ToString();
                    usuarioOBJ.usuario = registro["usuario"].ToString();
                    usuarioOBJ.contrasena = registro["contrasena"].ToString();
                    usuarioOBJ.estatus = int.Parse(registro["estatus"].ToString());
                    PerfilDAO perfilDAO = new PerfilDAO();
                    usuarioOBJ.perfil_id = perfilDAO.selectPerfilById(int.Parse(registro["perfil_id"].ToString()));
                }
                return usuarioOBJ;
            }
            else
            {
                return null;
            }



        }


        public void agregarUsuario(string nombre, string usuario, string contrasena, int estatus, int perfilID)
        {
            DataSource ds = new DataSource();
            string sql = "INSERT INTO usuario (Id,nombre,usuario,contrasena,estatus,perfil_id)" + 
                " VALUES (null,'"+nombre+"','"+usuario+"','"+contrasena+"',"+estatus+","+perfilID+")";
            ds.ejecutarConsulta(sql);
        }

        
    }
}
