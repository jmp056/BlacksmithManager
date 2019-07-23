using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }
        public string Nombres { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }
        public Empleados()
        {
            EmpleadoId = 0;
            Nombres = string.Empty;
            Cedula = string.Empty;
            FechaIngreso = DateTime.Now;
            Celular = string.Empty;
            Telefono = string.Empty;
            Email = string.Empty;
            Estado = string.Empty;
            Usuario = string.Empty;
        }
    }
}
