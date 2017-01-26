﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Entities;

namespace Universidad.Context.Entities.Configuration
{
    public class AlumnoConfiguration : EntityTypeConfiguration<Alumno>
    {
        public AlumnoConfiguration()
        {
            ToTable("Alumno");

            HasKey(c => c.AlumnoId);

            Property(c => c.ApellidoMaterno).HasMaxLength(60);

            Property(c => c.ApellidoPaterno).HasMaxLength(60);

            Property(c => c.Nombres).HasMaxLength(100);

            Property(c => c.Codigo).HasMaxLength(10);

            HasRequired(c => c.Genero)
                .WithMany(c => c.Alumnos)
                .HasForeignKey(c => c.GeneroId);

            HasRequired(c => c.EstadoCivil)
                .WithMany(c => c.Alumnos)
                .HasForeignKey(c => c.EstadoCivilId);          
        }
    }
}
