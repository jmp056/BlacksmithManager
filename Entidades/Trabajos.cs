﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Entidades
{
    public class Trabajos
    {
        [Key]
        public int TrabajoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public string Cliente { get; set; }
        public string TipoTrabajo { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public decimal Precio { get; set; }
        public string Encargado { get; set; }
        public decimal Ajuste { get; set; }
        public virtual List<Movimientos> Movimientos { get; set; }
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
            Cliente = string.Empty;
            TipoTrabajo = string.Empty;
            Descripcion = string.Empty;
            Direccion = String.Empty;
            Precio = 0;
            Encargado = String.Empty;
            Ajuste = 0;
            Movimientos = new List<Movimientos>();
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
