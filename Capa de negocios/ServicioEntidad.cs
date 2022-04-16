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

        public void Agregar(string descripcion, string direccion, string localidad, string numeroDocumento, string telefono, int idGrupoEntidad, int idTipoEntidad, string userName, string password, string comentario, DateTime fecha, string status = "Activa", string rol = "User", int limiteCredito = 0, string tipoEntidad = "Juridica", string tipoDocumento = "RNC", bool eliminable = false, string urlWeb = "", string urlFacebook = "", string urlInstagram = "", string urlTwitter = "", string urlTiktok = "")
        {
            Entidad newEntidad = new Entidad();

            newEntidad.Descripcion = descripcion;
            newEntidad.Direccion = direccion;
            newEntidad.Localidad = localidad;
            newEntidad.TipoEntidad = tipoEntidad;
            newEntidad.TipoDocumento = tipoDocumento;
            newEntidad.NumeroDocumento = numeroDocumento;
            newEntidad.Telefonos = telefono;
            newEntidad.URLPaginaWeb = urlWeb;
            newEntidad.URLFacebook = urlFacebook;
            newEntidad.URLInstagram = urlInstagram;
            newEntidad.URLTikTok = urlTiktok;
            newEntidad.URLTwitter = urlTwitter;
            newEntidad.IdGrupoEntidad = idGrupoEntidad;
            newEntidad.IdTipoEntidad = idTipoEntidad;
            newEntidad.LimiteCredito = limiteCredito;
            newEntidad.UserNameEntidad = userName;
            newEntidad.PasswordEntidad = password;
            newEntidad.RolUserEntidad = rol;
            newEntidad.Comentario = comentario;
            newEntidad.Status = status;
            newEntidad.NoEliminable = eliminable;
            newEntidad.FechaRegistro = fecha;

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
