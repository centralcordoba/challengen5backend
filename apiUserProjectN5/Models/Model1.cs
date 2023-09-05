using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace apiUserProjectN5.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Permiso> Permisos { get; set; }
        public virtual DbSet<TiposPermiso> TiposPermisos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permiso>()
                .Property(e => e.NombreEmpleado)
                .IsFixedLength();

            modelBuilder.Entity<Permiso>()
                .Property(e => e.ApellidoEmpleado)
                .IsFixedLength();

            modelBuilder.Entity<Permiso>()
                .Property(e => e.FechaPermiso)
                .IsFixedLength();

            modelBuilder.Entity<TiposPermiso>()
                .Property(e => e.Descripcion)
                .IsFixedLength();
        }
    }
}
