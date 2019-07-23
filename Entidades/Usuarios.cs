using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public int NivelUsuario { get; set; }
        public string Usuario { get; set; }

        [Browsable(false)]
        public string Clave { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Estado { get; set; }
        public string UsuarioR { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombres = string.Empty;
            Email = string.Empty;
            NivelUsuario = 0;
            Usuario = string.Empty;
            Clave = string.Empty;
            FechaIngreso = DateTime.Now;
            Estado = string.Empty;
            UsuarioR = string.Empty;
        }
    }
}
