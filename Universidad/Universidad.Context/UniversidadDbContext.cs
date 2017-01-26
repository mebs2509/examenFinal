using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Context.Entities.Configuration;
using Universidad.Entities;

namespace Universidad.Context
{
    public class UniversidadDbContext : System.Data.Entity.DbContext
    {
        public DbSet<Alumno> Alumno { get; set; }

        public DbSet<Genero> Genero { get; set; }

        public DbSet<EstadoCivil> EstadoCivil { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new AlumnoConfiguration());

            modelBuilder.Configurations.Add(new GeneroConfiguration());

            modelBuilder.Configurations.Add(new EstadoCivilConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
