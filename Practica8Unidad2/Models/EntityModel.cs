namespace Practica8Unidad2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityModel : DbContext
    {
        public EntityModel()
            : base("name=EntityModel")
        {
        }

        public virtual DbSet<Curso> Cursoes { get; set; }
        public virtual DbSet<Estudiante> Estudiantes { get; set; }
        public virtual DbSet<Inscripcion> Inscripcions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Estudiante>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);
        }
    }
}
