using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_de_acceso_a_datos
{
    class RepositorioTipoEntidad
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpTiposEntidadesListar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }

        public void Agregar(modelos.TipoEntidad entidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpTiposEntidadesInsertar";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@descripcion", entidad.Descripcion);
            comando.Parameters.AddWithValue("@idGrupoEntidad", entidad.Descripcion);
            comando.Parameters.AddWithValue("@comentario", entidad.Comentario);
            comando.Parameters.AddWithValue("@status", entidad.Status);
            comando.Parameters.AddWithValue("@noEliminable", entidad.NoEliminable);
            comando.Parameters.AddWithValue("@fechaRegistro", entidad.FechaRegistro);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

            conexion.CerrarConexion();
        }

        public void Actualizar(modelos.TipoEntidad entidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpTiposEntidadesActualizar";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@descripcion", entidad.Descripcion);
            comando.Parameters.AddWithValue("@idGrupoEntidad", entidad.Descripcion);
            comando.Parameters.AddWithValue("@comentario", entidad.Comentario);
            comando.Parameters.AddWithValue("@status", entidad.Status);
            comando.Parameters.AddWithValue("@noEliminable", entidad.NoEliminable);
            comando.Parameters.AddWithValue("@fechaRegistro", entidad.FechaRegistro);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpTiposEntidadesEliminar";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idGrupoEntidad", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
