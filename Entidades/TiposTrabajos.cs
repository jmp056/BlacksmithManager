﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TiposTrabajos
    {
        [Key]
        public int TipoTrabajoId { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioId { get; set; }

        public TiposTrabajos()
        {
            TipoTrabajoId = 0;
            Descripcion = string.Empty;
            FechaCreacion = DateTime.Now;
            UsuarioId = 0;
        }
    }
}
