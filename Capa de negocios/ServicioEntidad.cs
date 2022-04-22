using System;
using System.Data;

using Capa_de_acceso_a_datos;
using Capa_de_acceso_a_datos.modelos;

namespace Capa_de_negocio
{
    public class ServicioEntidad
    {
        private readonly RepositorioEntidades repositorio = new RepositorioEntidades();

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            tabla = repositorio.Mostrar();
            return tabla;
        }

        public void Login(string username, string password)
        {

        }

        public void Agregar(string descripcion, string direccion, string localidad, string numeroDocumento, string telefono, int idGrupoEntidad, int idTipoEntidad, string userName, string password, string comentario, DateTime fecha, string status = "Activa", string rol = "User", int limiteCredito = 0, string tipoEntidad = "Juridica", string tipoDocumento = "RNC", bool eliminable = false, string urlWeb = "", string urlFacebook = "", string urlInstagram = "", string urlTwitter = "", string urlTiktok = "")
        {
            Entidad newEntidad = new Entidad
            {
                Descripcion = descripcion,
                Direccion = direccion,
                Localidad = localidad,
                TipoEntidad = tipoEntidad,
                TipoDocumento = tipoDocumento,
                NumeroDocumento = numeroDocumento,
                Telefonos = telefono,
                URLPaginaWeb = urlWeb,
                URLFacebook = urlFacebook,
                URLInstagram = urlInstagram,
                URLTikTok = urlTiktok,
                URLTwitter = urlTwitter,
                IdGrupoEntidad = idGrupoEntidad,
                IdTipoEntidad = idTipoEntidad,
                LimiteCredito = limiteCredito,
                UserNameEntidad = userName,
                PasswordEntidad = password,
                RolUserEntidad = rol,
                Comentario = comentario,
                Status = status,
                NoEliminable = eliminable,
                FechaRegistro = fecha
            };

            repositorio.Agregar(newEntidad);
        }

        public void Actualizar(Entidad entidad)
        {
            repositorio.Actualizar(entidad);
        }

        public void Eliminar(string id)
        {
            repositorio.Eliminar(Convert.ToInt32(id));
        }
    }
}
