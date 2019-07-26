using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RecibosIngresos
    {
        [Key]
        public int ReciboIngresoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Trabajo { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }

        public RecibosIngresos()
        {
            ReciboIngresoId = 0;
            Fecha = DateTime.Now;
            Cliente = string.Empty;
            Trabajo = string.Empty;
            Descripcion = string.Empty;
            Monto = 0;
        }
    }
}
