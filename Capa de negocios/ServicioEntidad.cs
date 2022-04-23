using System;
using System.Data;

using Capa_de_acceso_a_datos;
using Capa_de_acceso_a_datos.modelos;
using CryptoLib;

namespace Capa_de_negocio
{
    public class ServicioEntidad
    {
        private readonly RepositorioEntidades repositorio = new RepositorioEntidades();

        public DataTable Mostrar()
        {
            return repositorio.Mostrar();
        }

        public bool Login(string username, string password)
        {
            Entidad entidad = new Entidad
            {
                UserNameEntidad = username,
                PasswordEntidad = Encryptor.MD5Hash(password)
            };

            try
            {
                DataTable logged = repositorio.Login(entidad);
                if(logged.Rows[0][0].ToString() == "1")
                {
                    return true;
                } else
                {
                    return false;
                }
            } catch
            {
                return false;
            }

        }

        public bool Agregar(string descripcion, string direccion, string localidad, string numeroDocumento, string telefono, string idGrupoEntidad, string idTipoEntidad, string userName, string password, string comentario, string status = "Activa", string rol = "User", int limiteCredito = 0, string tipoEntidad = "Juridica", string tipoDocumento = "RNC", bool eliminable = false, string urlWeb = "", string urlFacebook = "", string urlInstagram = "", string urlTwitter = "", string urlTiktok = "")
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
                PasswordEntidad = Encryptor.MD5Hash(password),
                RolUserEntidad = rol,
                Comentario = comentario,
                Status = status,
                NoEliminable = eliminable,
            };

            try
            {
                repositorio.Agregar(newEntidad);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Actualizar(string id, string type, dynamic value)
        {
            Entidad entidad = new Entidad
            {
                IdEntidad = Int32.Parse(id)
            };

            if (type == "Descripcion")
            {
                entidad.Descripcion = value;
            }

            if (type == "Direccion")
            {
                entidad.Direccion = value;
            }

            if (type == "Localidad")
            {
                entidad.Localidad = value;
            }

            if (type == "TipoEntidad")
            {
                entidad.TipoEntidad = value;
            }

            if (type == "TipoDocumento")
            {
                entidad.TipoDocumento = value;
            }

            if (type == "NumeroDocumento")
            {
                entidad.NumeroDocumento = value;
            }

            if (type == "Telefonos")
            {
                entidad.Telefonos = value;
            }

            if (type == "URLPaginaWeb")
            {
                entidad.URLPaginaWeb = value;
            }

            if (type == "URLFacebook")
            {
                entidad.URLFacebook = value;
            }

            if (type == "URLInstagram")
            {
                entidad.URLInstagram = value;
            }

            if (type == "URLTwitter")
            {
                entidad.URLTwitter = value;
            }

            if (type == "URLTikTok")
            {
                entidad.URLTikTok = value;
            }

            if (type == "IdGrupoEntidad")
            {
                entidad.IdGrupoEntidad = value;
            }

            if (type == "IdTipoEntidad")
            {
                entidad.IdTipoEntidad = value;
            }

            if (type == "LimiteCredito")
            {
                entidad.LimiteCredito = Int32.Parse(value);
            }

            if (type == "UserNameEntidad")
            {
                entidad.UserNameEntidad = value;
            }

            if (type == "PasswordEntidad")
            {
                entidad.PasswordEntidad = value;
            }

            if (type == "RolUserEntidad")
            {
                entidad.RolUserEntidad = value;
            }

            if (type == "Comentario")
            {
                entidad.Comentario = value;
            }

            if (type == "Status")
            {
                entidad.Status = value;
            }

            if (type == "NoEliminable")
            {
                entidad.NoEliminable = value;
            }

            try
            {
                repositorio.Actualizar(entidad, type);
                return true;
            } catch
            {
                return false;
            }
        }

        public void Eliminar(string id)
        {
            Entidad entidad = new Entidad
            {
                IdEntidad = Convert.ToInt32(id)
            };

            repositorio.Eliminar(entidad);
        }
    }
}
