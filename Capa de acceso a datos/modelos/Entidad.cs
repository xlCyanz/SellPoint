using System;

namespace Capa_de_acceso_a_datos.modelos
{
    public class Entidad
    {
        public int IdEntidad { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string TipoEntidad { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Telefonos { get; set; }
        public string URLPaginaWeb { get; set; }
        public string URLFacebook { get; set; }
        public string URLInstagram { get; set; }
        public string URLTwitter { get; set; }
        public string URLTikTok { get; set; }
        public int IdGrupoEntidad { get; set; }
        public int IdTipoEntidad { get; set; }
        public int LimiteCredito { get; set; }
        public string UserNameEntidad { get; set; }
        public string PasswordEntidad { get; set; }
        public string RolUserEntidad { get; set; }
        public string Comentario { get; set; }
        public string Status { get; set; }
        public bool NoEliminable { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Entidad()
        {
            this.TipoEntidad = "Juridica";
            this.TipoDocumento = "RNC";
            this.LimiteCredito = 0;
            this.RolUserEntidad = "User";
            this.Status = "Activa";
            this.NoEliminable = false;
            this.FechaRegistro = DateTime.Now;
        }
    }
}
