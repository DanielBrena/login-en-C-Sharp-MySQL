using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using MySql.Data.MySqlClient;


namespace ConsoleApplication15
{
    class DataSource
    {
        private string cadenaConexion;
        private MySqlConnection conexion;


        public DataSource()
        {
            this.cadenaConexion = "Server=127.0.0.1; Database=02daniel; Uid=root; Pwd=danielbrena2";
            this.conexion = new MySqlConnection(this.cadenaConexion);
            this.conexion.ConnectionString = this.cadenaConexion;
            this.conexion.Open();

        }
        /**
          * Metodo que ejecutara la consulta para regresar una tabla con los
         * registros
          * @return 
          * 
          * */
        public DataTable ejecutarConsulta(string sql)
        {
            //Enviar consultas
            MySqlCommand instruccion = this.conexion.CreateCommand();
            instruccion.CommandText = sql;
            //Leer el conjunto de resultados de la consulta
            MySqlDataReader reader = instruccion.ExecuteReader();

            //Cargar los datos que vienen del reader
            DataTable dt = new DataTable();
            dt.Load(reader);
            this.conexion.Close();
            return dt;
        }
        
        /**
         * Metodo que regresa el numero de filas afectadas
         * @param sql Es la consulta a pasar
         * 
         * */
        public int ejecutarActualizacion(string sql)
        {
            return 0;
        }

    }
}
