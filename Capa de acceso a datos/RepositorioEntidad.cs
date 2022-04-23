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
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpEntidadesListar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();

            DataTable tabla = new DataTable();
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

        public void Actualizar(Entidad entidad, string type)
        {
            comando.Connection = conexion.AbrirConexion();

            if (type == "Descripcion")
            {
                comando.CommandText = "UPDATE Entidades SET Descripcion = @Descripcion WHERE IdEntidad = @IdEntidad";
                comando.Parameters.AddWithValue("@Descripcion", entidad.Descripcion);
            }

            if (type == "Direccion")
            {
                comando.CommandText = "UPDATE Entidades SET Direccion = @Direccion WHERE IdEntidad = @IdEntidad";
                comando.Parameters.AddWithValue("@Direccion", entidad.Direccion);
            }

            if (type == "Localidad")
            {
                comando.CommandText = "UPDATE Entidades SET Localidad = @Localidad WHERE IdEntidad = @IdEntidad";
                comando.Parameters.AddWithValue("@Localidad", entidad.Localidad);
            }

            if (type == "TipoEntidad")
            {
                comando.CommandText = "UPDATE Entidades SET TipoEntidad = @TipoEntidad WHERE IdEntidad = @IdEntidad";
                comando.Parameters.AddWithValue("@TipoEntidad", entidad.TipoEntidad);
            }

            if (type == "TipoDocumento")
            {
                comando.CommandText = "UPDATE Entidades SET TipoDocumento = @TipoDocumento WHERE IdEntidad = @IdEntidad";
                comando.Parameters.AddWithValue("@TipoDocumento", entidad.TipoDocumento);
            }

            if (type == "NumeroDocumento")
            {
                comando.CommandText = "UPDATE Entidades SET NumeroDocumento = @NumeroDocumento WHERE IdEntidad = @IdEntidad";
                comando.Parameters.AddWithValue("@NumeroDocumento", entidad.NumeroDocumento);
            }

            if (type == "Telefono")
            {
                comando.CommandText = "UPDATE Entidades SET Telefono = @Telefono WHERE IdEntidad = @IdEntidad";
                comando.Parameters.AddWithValue("@Telefono", entidad.Telefonos);
            }

            if (type == "URLPaginaWeb")
            {
                comando.CommandText = "UPDATE Entidades SET URLPaginaWeb = @URLPaginaWeb WHERE IdEntidad = @IdEntidad";
                comando.Parameters.AddWithValue("@URLPaginaWeb", entidad.URLPaginaWeb);
            }

            if (type == "URLFacebook")
            {
                comando.CommandText = "UPDATE Entidades SET URLFacebook = @URLFacebook WHERE IdEntidad = @IdEntidad";
                comando.Parameters.AddWithValue("@URLFacebook", entidad.URLFacebook);
            }

            if (type == "URLInstagram")
            {
                comando.CommandText = "UPDATE Entidades SET URLInstagram = @URLInstagram WHERE IdEntidad = @IdEntidad";
                comando.Parameters.AddWithValue("@URLInstagram", entidad.URLInstagram);
            }

            if (type == "URLTwitter")
            {
                comando.CommandText = "UPDATE Entidades SET URLTwitter = @URLTwitter WHERE IdEntidad = @IdEntidad";
                comando.Parameters.AddWithValue("@URLTwitter", entidad.URLTwitter);
            }

            if (type == "URLTikTok")
            {
                comando.CommandText = "UPDATE Entidades SET URLTikTok = @URLTikTok WHERE IdEntidad = @IdEntidad";
                comando.Parameters.AddWithValue("@URLTikTok", entidad.URLTikTok);
            }

            if (type == "IdGrupoEntidad")
            {
                comando.CommandText = "UPDATE Entidades SET IdGrupoEntidad = @IdGrupoEntidad WHERE IdEntidad = @IdEntidad";
                comando.Parameters.AddWithValue("@IdGrupoEntidad", entidad.IdGrupoEntidad);
            }

            if (type == "IdTipoEntidad")
            {
                comando.CommandText = "UPDATE Entidades SET IdTipoEntidad = @IdTipoEntidad WHERE IdEntidad = @IdEntidad";
                comando.Parameters.AddWithValue("@IdTipoEntidad", entidad.IdTipoEntidad);
            }

            if (type == "LimiteCredito")
            {
                comando.CommandText = "UPDATE Entidades SET LimiteCredito = @LimiteCredito WHERE IdEntidad = @IdEntidad";
                comando.Parameters.AddWithValue("@LimiteCredito", entidad.LimiteCredito);
            }

            if (type == "UserNameEntidad")
            {
                comando.CommandText = "UPDATE Entidades SET UserNameEntidad = @UserNameEntidad WHERE IdEntidad = @IdEntidad";
                comando.Parameters.AddWithValue("@UserNameEntidad", entidad.UserNameEntidad);
            }

            if (type == "PasswordEntidad")
            {
                comando.CommandText = "UPDATE Entidades SET PasswordEntidad = @PasswordEntidad WHERE IdEntidad = @IdEntidad";
                comando.Parameters.AddWithValue("@PasswordEntidad", entidad.PasswordEntidad);
            }

            if (type == "RolUserEntidad")
            {
                comando.CommandText = "UPDATE Entidades SET RolUserEntidad = @RolUserEntidad WHERE IdEntidad = @IdEntidad";
                comando.Parameters.AddWithValue("@RolUserEntidad", entidad.RolUserEntidad);
            }

            if (type == "Comentario")
            {
                comando.CommandText = "UPDATE Entidades SET Comentario = @Comentario WHERE IdEntidad = @IdEntidad";
                comando.Parameters.AddWithValue("@Comentario", entidad.Comentario);
            }

            if (type == "Status")
            {
                comando.CommandText = "UPDATE Entidades SET Status = @Status WHERE IdEntidad = @IdEntidad";
                comando.Parameters.AddWithValue("@Status", entidad.Status);
            }

            if (type == "NoEliminable")
            {
                comando.CommandText = "UPDATE Entidades SET NoEliminable = @NoEliminable WHERE IdEntidad = @IdEntidad";
                comando.Parameters.AddWithValue("@NoEliminable", entidad.NoEliminable);
            }

            comando.Parameters.AddWithValue("@IdEntidad", entidad.IdEntidad);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(Entidad entidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SpEntidadesEliminar";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdEntidad", entidad.IdEntidad);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}