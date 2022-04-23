using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Capa_de_acceso_a_datos
{
    public class Conexion
    {
        readonly private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString);
        
        public SqlConnection AbrirConexion()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            return conn;
        }
        public SqlConnection CerrarConexion()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return conn;
        }
    }
}
