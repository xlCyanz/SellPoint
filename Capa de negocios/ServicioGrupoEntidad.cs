using System;
using System.Data;

using Capa_de_acceso_a_datos;
using Capa_de_acceso_a_datos.modelos;

namespace Capa_de_negocio
{
    public class ServicioGrupoEntidad
    {
        private readonly RepositorioGrupoEntidad repositorio = new RepositorioGrupoEntidad();

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            tabla = repositorio.Mostrar();
            return tabla;
        }

        public void Agregar(string descripcion, string comentario, DateTime fecha, string status = "Activa", bool eliminable = false)
        {
            GrupoEntidad newEntidad = new GrupoEntidad();

            newEntidad.Descripcion = descripcion;
            newEntidad.Comentario = comentario;
            newEntidad.Status = status;
            newEntidad.NoEliminable = eliminable;
            newEntidad.FechaRegistro = fecha;

            repositorio.Agregar(newEntidad);
        }
        public void Actualizar(GrupoEntidad entidad)
        {
            repositorio.Actualizar(entidad);
        }
        public void Eliminar(string id)
        {
            repositorio.Eliminar(Convert.ToInt32(id));
        }
    }
}
