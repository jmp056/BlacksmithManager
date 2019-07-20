using System;
using System.Collections.Generic;
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
        public virtual Clientes Cliente { get; set; }


        public string TipoTrabajo { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public decimal Precio { get; set; }
        public string Encargado { get; set; }
        public decimal Ajuste { get; set; }
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
            //Cliente = string.Empty;
            TipoTrabajo = string.Empty;
            Descripcion = string.Empty;
            Direccion = String.Empty;
            Precio = 0;
            Encargado = String.Empty;
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
