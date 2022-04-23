using System;
using System.Data;
using System.Data.SqlClient;

using Capa_de_acceso_a_datos.modelos;

namespace Capa_de_acceso_a_datos
{
    public class RepositorioGrupoEntidad
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpGruposEntidadesListar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();

            DataTable tabla = new DataTable();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }

        public void Agregar(GrupoEntidad entidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpGruposEntidadesInsertar";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Descripcion", entidad.Descripcion);
            comando.Parameters.AddWithValue("@Comentario", entidad.Comentario);
            comando.Parameters.AddWithValue("@Status", entidad.Status);
            comando.Parameters.AddWithValue("@NoEliminable", entidad.NoEliminable);
            comando.Parameters.AddWithValue("@FechaRegistro", entidad.FechaRegistro);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

            conexion.CerrarConexion();
        }

        public void Actualizar(GrupoEntidad entidad, string type)
        {
            comando.Connection = conexion.AbrirConexion();

            if(type == "Descripcion")
            {
                comando.CommandText = "UPDATE GruposEntidades SET Descripcion = @Descripcion WHERE IdGrupoEntidad = @IdGrupoEntidad";
                comando.Parameters.AddWithValue("@Descripcion", entidad.Descripcion);
            }

            if (type == "Comentario")
            {
                comando.CommandText = "UPDATE GruposEntidades SET Comentario = @Comentario WHERE IdGrupoEntidad = @IdGrupoEntidad";
                comando.Parameters.AddWithValue("@Comentario", entidad.Comentario);
            }

            if (type == "Status")
            {
                comando.CommandText = "UPDATE GruposEntidades SET Status = @Status WHERE IdGrupoEntidad = @IdGrupoEntidad";
                comando.Parameters.AddWithValue("@Status", entidad.Status);
            }

            if (type == "NoEliminable")
            {
                comando.CommandText = "UPDATE GruposEntidades SET NoEliminable = @NoEliminable WHERE IdGrupoEntidad = @IdGrupoEntidad";
                comando.Parameters.AddWithValue("@NoEliminable", entidad.NoEliminable);
            }

            comando.Parameters.AddWithValue("@IdGrupoEntidad", entidad.IdGrupoEntidad);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(GrupoEntidad entidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpGruposEntidadesEliminar";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdGrupoEntidad", entidad.IdGrupoEntidad);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
}
}
