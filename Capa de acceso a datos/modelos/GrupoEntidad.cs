using System;

namespace Capa_de_acceso_a_datos.modelos
{
    public class GrupoEntidad
    {
        public int IdGrupoEntidad { get; set; }
        public string Descripcion { get; set; }
        public string Comentario { get; set; }
        public string Status { get; set; }
        public bool NoEliminable { get; set; }
        public DateTime FechaRegistro { get; set; }

        public GrupoEntidad()
        {
            this.Status = "Activa";
            this.NoEliminable = false;
            this.FechaRegistro = DateTime.Now;
        }
    }

}
