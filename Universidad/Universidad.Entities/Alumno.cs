using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Entities
{
    public class Alumno
    {
        public int AlumnoId { get; set; }

        public DateTime Created { get; set; }

        public String Codigo { get; set; }

        public String Apellidos { get; set; }

        public String Nombres { get; set; }

        [DisplayName("Genero")]
        public int GeneroId { get; set; }

        [DisplayName("Genero")]
        public Genero Genero { get; set; }

        [DisplayName("Estado Civil")]
        public int EstadoCivilId { get; set; }

        [DisplayName("Estado Civil")]
        public EstadoCivil EstadoCivil { get; set; }

         
        
        
    }
}
