using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Movimientos
    {
        [Key]
        public int MovimientoId { get; set; }
        public int TrabajoId { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public string TipoMovimiento { get; set; }
        public string Descripcion { get; set; }
        public decimal Valor { get; set; }

        public Movimientos()
        {
            MovimientoId = 0;
            TrabajoId = 0;
            FechaMovimiento = DateTime.Now;
            TipoMovimiento = string.Empty;
            Descripcion = string.Empty;
            Valor = 0;
        }

        public Movimientos(int movimientoId, int trabajoId, DateTime fechaMovimiento, string tipoMovimiento, string descripcion, decimal valor)
        {
            MovimientoId = movimientoId;
            TrabajoId = trabajoId;
            FechaMovimiento = fechaMovimiento;
            TipoMovimiento = tipoMovimiento;
            Descripcion = descripcion;
            Valor = valor;
        }
    }
}
