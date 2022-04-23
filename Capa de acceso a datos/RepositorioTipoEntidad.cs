using System;
using System.Data;
using System.Data.SqlClient;

using Capa_de_acceso_a_datos.modelos;

namespace Capa_de_acceso_a_datos
{
    public class RepositorioTipoEntidad
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpTiposEntidadesListar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();

            DataTable tabla = new DataTable();
            tabla.Load(leer);

            conexion.CerrarConexion();

            return tabla;
        }

        public DataTable BuscarPorGrupoEntidad(TipoEntidad entidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpTiposEntidadesObtenerPerGrupoEntidad";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdGrupoEntidad", entidad.IdGrupoEntidad);

            leer = comando.ExecuteReader();

            DataTable tabla = new DataTable();
            tabla.Load(leer);

            conexion.CerrarConexion();

            return tabla;
        }

        public void Agregar(TipoEntidad entidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpTiposEntidadesInsertar";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Descripcion", entidad.Descripcion);
            comando.Parameters.AddWithValue("@IdGrupoEntidad", entidad.IdGrupoEntidad);
            comando.Parameters.AddWithValue("@Comentario", entidad.Comentario);
            comando.Parameters.AddWithValue("@Status", entidad.Status);
            comando.Parameters.AddWithValue("@NoEliminable", entidad.NoEliminable);
            comando.Parameters.AddWithValue("@FechaRegistro", entidad.FechaRegistro);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

            conexion.CerrarConexion();
        }

        public void Actualizar(TipoEntidad entidad, string type)
        {
            comando.Connection = conexion.AbrirConexion();

            if (type == "Descripcion")
            {
                comando.CommandText = "UPDATE TiposEntidades SET Descripcion = @Descripcion WHERE IdTipoEntidad = @IdTipoEntidad";
                comando.Parameters.AddWithValue("@Descripcion", entidad.Descripcion);
            }

            if (type == "Comentario")
            {
                comando.CommandText = "UPDATE TiposEntidades SET Comentario = @Comentario WHERE IdTipoEntidad = @IdTipoEntidad";
                comando.Parameters.AddWithValue("@Comentario", entidad.Comentario);
            }

            if (type == "Status")
            {
                comando.CommandText = "UPDATE TiposEntidades SET Status = @Status WHERE IdTipoEntidad = @IdTipoEntidad";
                comando.Parameters.AddWithValue("@Status", entidad.Status);
            }

            if (type == "NoEliminable")
            {
                comando.CommandText = "UPDATE TiposEntidades SET NoEliminable = @NoEliminable WHERE IdTipoEntidad = @IdTipoEntidad";
                comando.Parameters.AddWithValue("@NoEliminable", entidad.NoEliminable);
            }

            comando.Parameters.AddWithValue("@IdTipoEntidad", entidad.IdTipoEntidad);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(TipoEntidad entidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpTiposEntidadesEliminar";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdTipoEntidad", entidad.IdTipoEntidad);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
