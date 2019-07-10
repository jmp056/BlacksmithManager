using System;
using System.ComponentModel.DataAnnotations;


namespace Entidades
{
    public class Trabajos
    {
        [Key]
        public int TrabajoId { get; set; }
        public DateTime FechaInicio { get; set; }

    }
}
