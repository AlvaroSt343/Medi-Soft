using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Medi_Soft.Clases
{
    class MyConnection
    {
        public MySqlConnection conexion;

        public void abrirConexion()
        {
            String servidor = "localhost";
            String puerto = "3306";
            String usuario = "admin";
            String password = "admin";
            String database = "Hospital_BD";

            //Esta es la cadena para abrir la conexion
            String laConexion = String.Format("server={0};port={1};user id={2}; password={3}; database={4}", servidor, puerto, usuario, password, database);
            conexion = new MySqlConnection(laConexion);
            conexion.Open();
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public MySqlConnection GetConexion()
        {
            return conexion;
        }
    }
}
