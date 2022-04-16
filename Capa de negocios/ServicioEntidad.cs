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
            Console.WriteLine(descripcion);

            newEntidad.Direccion = direccion;
            Console.WriteLine(direccion);

            newEntidad.Localidad = localidad;
            Console.WriteLine(localidad);

            newEntidad.TipoEntidad = tipoEntidad;
            Console.WriteLine(tipoEntidad);

            newEntidad.TipoDocumento = tipoDocumento;
            Console.WriteLine(tipoDocumento);

            newEntidad.NumeroDocumento = numeroDocumento;
            Console.WriteLine(numeroDocumento);

            newEntidad.Telefonos = telefono;
            Console.WriteLine("Telefonos: {0}", telefono);

            newEntidad.URLPaginaWeb = urlWeb;
            Console.WriteLine(urlWeb);

            newEntidad.URLFacebook = urlFacebook;
            Console.WriteLine(urlFacebook);

            newEntidad.URLInstagram = urlInstagram;
            Console.WriteLine(urlInstagram);

            newEntidad.URLTikTok = urlTiktok;
            Console.WriteLine(urlTiktok);

            newEntidad.URLTwitter = urlTwitter;
            Console.WriteLine(urlTwitter);

            newEntidad.IdGrupoEntidad = idGrupoEntidad;
            Console.WriteLine(idGrupoEntidad);

            newEntidad.IdTipoEntidad = idTipoEntidad;
            Console.WriteLine(idTipoEntidad);

            newEntidad.LimiteCredito = limiteCredito;
            Console.WriteLine(limiteCredito);

            newEntidad.UserNameEntidad = userName;
            Console.WriteLine(userName);

            newEntidad.PasswordEntidad = password;
            Console.WriteLine(password);

            newEntidad.RolUserEntidad = rol;
            Console.WriteLine(rol);

            newEntidad.Comentario = comentario;
            Console.WriteLine(comentario);

            newEntidad.Status = status;
            Console.WriteLine(status);

            newEntidad.NoEliminable = eliminable;
            Console.WriteLine(eliminable);

            newEntidad.FechaRegistro = fecha;
            Console.WriteLine(fecha);

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
