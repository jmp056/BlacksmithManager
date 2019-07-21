using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class Trabajos
    {
        [Key]
        public int TrabajoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        [Browsable(false)]
        public virtual Clientes Cliente{ get; set; }
        public int TipoTrabajoId { get; set; }
        [ForeignKey("TipoTrabajoId")]
        [Browsable(false)]
        public virtual TiposTrabajos TipoTrabajo { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public decimal Precio { get; set; }
        public int EmpleadoId { get; set; }
        [ForeignKey("EmpleadoId")]
        [Browsable(false)]
        public virtual Empleados Empleado { get; set; }
        public decimal Ajuste { get; set; }
        [Browsable(false)]
        public virtual List<Movimientos> Detalle { get; set; }
        public decimal Cobrado { get; set; }
        public decimal Balance { get; set; }
        public decimal AjustePagado { get; set; }
        public decimal AjustePendiente { get; set; }
        public decimal Materiales { get; set; }
        public decimal GananciaBruta { get; set; }
        public decimal GananciaNeta { get; set; }

        public Trabajos()
        {
            TrabajoId = 0;
            FechaInicio = DateTime.Now;
            ClienteId = 0;
            TipoTrabajoId = 0;
            Descripcion = string.Empty;
            Direccion = String.Empty;
            Precio = 0;
            EmpleadoId = 0;
            Ajuste = 0;
            Detalle = new List<Movimientos>();
            Cobrado = 0;
            Balance = 0;
            AjustePagado = 0;
            AjustePendiente = 0;
            Materiales = 0;
            GananciaBruta = 0;
            GananciaNeta = 0;
        }
    }

}
