using System.Data;
using System.Data.SqlClient;

namespace Capa_de_acceso_a_datos
{
    public class Conexion
    {
        private SqlConnection conn = new SqlConnection("Server=CYANZ-2772002\\MSSQLSERVERCUSTO;DataBase=sellpoint;Integrated Security=true");
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
