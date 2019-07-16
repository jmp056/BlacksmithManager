using Entidades;
using System.Data.Entity;

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Movimientos> Movimienos { get; set; }
        public DbSet<TiposTrabajos> TiposTrabajos { get; set; }
        public DbSet<Trabajos> Trabajos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public Contexto() : base("ConStr")
        { }
    }
}
