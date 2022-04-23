using System;
using System.Data;

using Capa_de_acceso_a_datos;
using Capa_de_acceso_a_datos.modelos;

namespace Capa_de_negocio
{
    public class ServicioTipoEntidad
    {
        private readonly RepositorioTipoEntidad repositorioTipoEntidad = new RepositorioTipoEntidad();

        public DataTable Mostrar()
        {
            return repositorioTipoEntidad.Mostrar();
        }

        public DataTable BuscarPorGrupoEntidad(string idGrupoEntidad)
        {
            TipoEntidad tipoEntidad = new TipoEntidad
            {
                IdGrupoEntidad = idGrupoEntidad
            };

            return repositorioTipoEntidad.BuscarPorGrupoEntidad(tipoEntidad);
        }
        public bool Agregar(string descripcion, string comentario, string idGrupoEntidad, string status = "Activa", bool eliminable = false)
        {
            TipoEntidad newTipoEntidad = new TipoEntidad
            {
                Descripcion = descripcion,
                Comentario = comentario,
                Status = status,
                NoEliminable = eliminable,
                IdGrupoEntidad = idGrupoEntidad
            };

            try
            {
                repositorioTipoEntidad.Agregar(newTipoEntidad);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Actualizar(string id, string type, dynamic value)
        {
            TipoEntidad tipoEntidad = new TipoEntidad();
            tipoEntidad.IdTipoEntidad = Int32.Parse(id);

            if (type == "Descripcion")
            {
                tipoEntidad.Descripcion = value;
            }

            if (type == "Comentario")
            {
                tipoEntidad.Comentario = value;
            }

            if (type == "Status")
            {
                tipoEntidad.Status = value;
            }

            if (type == "NoEliminable")
            {
                if (value == "True")
                {
                    tipoEntidad.NoEliminable = true;
                }
                else
                {
                    tipoEntidad.NoEliminable = false;
                }
            }

            try
            {
                repositorioTipoEntidad.Actualizar(tipoEntidad, type);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Eliminar(string id)
        {
            TipoEntidad entidad = new TipoEntidad
            {
                IdTipoEntidad = Int32.Parse(id),
            };

            try
            {
                repositorioTipoEntidad.Eliminar(entidad);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
