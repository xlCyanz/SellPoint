using System;
using System.Data;
using System.Data.SqlClient;

using Capa_de_acceso_a_datos.modelos;

namespace Capa_de_acceso_a_datos
{
    public class RepositorioEntidades
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpEntidadesListar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }

        public void Login(Entidad entidad)
        {

        }

        public void Agregar(Entidad entidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpEntidadesInsertar";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Connection = conexion.AbrirConexion();

            comando.Parameters.AddWithValue("@descripcion", entidad.Descripcion);
            comando.Parameters.AddWithValue("@direccion", entidad.Direccion);
            comando.Parameters.AddWithValue("@localidad", entidad.Localidad);
            comando.Parameters.AddWithValue("@tipoEntidad", entidad.TipoEntidad);
            comando.Parameters.AddWithValue("@tipoDocumento", entidad.TipoDocumento);
            comando.Parameters.AddWithValue("@numeroDocumento", entidad.NumeroDocumento);
            comando.Parameters.AddWithValue("@telefonos", entidad.Telefonos);
            comando.Parameters.AddWithValue("@urlPaginaWeb", entidad.URLPaginaWeb);
            comando.Parameters.AddWithValue("@urlFacebook", entidad.URLFacebook);
            comando.Parameters.AddWithValue("@urlInstagram", entidad.URLInstagram);
            comando.Parameters.AddWithValue("@urlTwitter", entidad.URLTwitter);
            comando.Parameters.AddWithValue("@urlTikTok", entidad.URLTikTok);
            comando.Parameters.AddWithValue("@idGrupoEntidad", entidad.IdGrupoEntidad);
            comando.Parameters.AddWithValue("@idTipoEntidad", entidad.IdTipoEntidad);
            comando.Parameters.AddWithValue("@limiteCredito", entidad.LimiteCredito);
            comando.Parameters.AddWithValue("@userNameEntidad", entidad.UserNameEntidad);
            comando.Parameters.AddWithValue("@passwordEntidad", entidad.PasswordEntidad);
            comando.Parameters.AddWithValue("@rolUserEntidad", entidad.RolUserEntidad);
            comando.Parameters.AddWithValue("@comentario", entidad.Comentario);
            comando.Parameters.AddWithValue("@status", entidad.Status);
            comando.Parameters.AddWithValue("@noEliminable", entidad.NoEliminable);
            comando.Parameters.AddWithValue("@fechaRegistro", entidad.FechaRegistro);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

            conexion.CerrarConexion();
        }

        public void Actualizar(Entidad entidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpEntidadesActualizar";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@descripcion", entidad.Descripcion);
            comando.Parameters.AddWithValue("@direccion", entidad.Direccion);
            comando.Parameters.AddWithValue("@localidad", entidad.Localidad);
            comando.Parameters.AddWithValue("@tipoEntidad", entidad.TipoEntidad);
            comando.Parameters.AddWithValue("@tipoDocumento", entidad.TipoDocumento);
            comando.Parameters.AddWithValue("@numeroDocumento", entidad.NumeroDocumento);
            comando.Parameters.AddWithValue("@telefono", entidad.Telefonos);
            comando.Parameters.AddWithValue("@urlPaginaWeb", entidad.URLPaginaWeb);
            comando.Parameters.AddWithValue("@urlFacebook", entidad.URLFacebook);
            comando.Parameters.AddWithValue("@urlInstagram", entidad.URLInstagram);
            comando.Parameters.AddWithValue("@urlTwitter", entidad.URLTwitter);
            comando.Parameters.AddWithValue("@urlTikTok", entidad.URLTikTok);
            comando.Parameters.AddWithValue("@idGrupoEntidad", entidad.IdGrupoEntidad);
            comando.Parameters.AddWithValue("@idTipoEntidad", entidad.IdTipoEntidad);
            comando.Parameters.AddWithValue("@limiteCredito", entidad.LimiteCredito);
            comando.Parameters.AddWithValue("@userNameEntidad", entidad.UserNameEntidad);
            comando.Parameters.AddWithValue("@passwordEntidad", entidad.PasswordEntidad);
            comando.Parameters.AddWithValue("@rolUserEntidad", entidad.RolUserEntidad);
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
            comando.CommandText = "SpEntidadesEliminar";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idEntidad", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}