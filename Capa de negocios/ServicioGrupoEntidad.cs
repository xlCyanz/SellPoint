using System;
using System.Data;

using Capa_de_acceso_a_datos;
using Capa_de_acceso_a_datos.modelos;

namespace Capa_de_negocio
{
    public class ServicioGrupoEntidad
    {
        private readonly RepositorioGrupoEntidad repositorioGrupoEntidad = new RepositorioGrupoEntidad();

        public DataTable Mostrar()
        {
            return repositorioGrupoEntidad.Mostrar();
        }

        public bool Agregar(string descripcion, string comentario, string status = "Activa", bool eliminable = false)
        {
            GrupoEntidad newGrupoEntidad = new GrupoEntidad
            {
                Descripcion = descripcion,
                Comentario = comentario,
                Status = status,
                NoEliminable = eliminable,
            };

            try
            {
                repositorioGrupoEntidad.Agregar(newGrupoEntidad);
                return true;
            }
             catch
            {
                return false;
            }
        }
        public bool Actualizar(string id, string type, dynamic value)
        {
            GrupoEntidad grupoEntidad = new GrupoEntidad
            {
                IdGrupoEntidad = Int32.Parse(id)
            };

            if(type == "Descripcion")
            {
                grupoEntidad.Descripcion = value;
            }

            if (type == "Comentario")
            {
                grupoEntidad.Comentario = value;
            }

            if (type == "Status")
            {
                grupoEntidad.Status = value;
            }

            if (type == "NoEliminable")
            {
                if(value == "True")
                {
                    grupoEntidad.NoEliminable = true;
                }
                else {
                    grupoEntidad.NoEliminable = false;
                }
            }

            try
            {
                repositorioGrupoEntidad.Actualizar(grupoEntidad, type);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Eliminar(string id)
        {
            GrupoEntidad grupoEntidad = new GrupoEntidad
            {
                IdGrupoEntidad = Int32.Parse(id),
            };

            try
            {
                repositorioGrupoEntidad.Eliminar(grupoEntidad);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
