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
    public class EstadoCivilConfiguration : EntityTypeConfiguration<EstadoCivil>
    {
        public EstadoCivilConfiguration()
        {
            ToTable("Estado Civil");

            HasKey(a => a.Id);

	    Property(a => a.Id).
                HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Descripcion)
		.IsRequired()
		.HasMaxLength(50);
        }   
    }
}
