using System.ComponentModel.DataAnnotations;
using System;

namespace Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string  Direccion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }

        public Clientes()
        {
            ClienteId = 0;
            Nombres = string.Empty;
            Celular = string.Empty;
            Telefono = string.Empty;
            Email = string.Empty;
            Direccion = string.Empty;
            FechaIngreso = DateTime.Now;
            Estado = string.Empty;
            Usuario = string.Empty;
        }
    }
}
