using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Entities;

namespace Universidad.Context.Entities.Configuration
{
    public class GeneroConfiguration :  EntityTypeConfiguration<Genero>
    {
        public GeneroConfiguration()
        {
            ToTable("Genero");

            HasKey(b => b.Id);

	    Property(b => b.Id).
                HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(b => b.Descripcion)
		.IsRequired()
		.HasMaxLength(255);
        }
    }
}
