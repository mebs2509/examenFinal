using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Entities
{
    public class Alumno
    {
        public int AlumnoId { get; set; }

        public String Codigo { get; set; }

        public String ApellidoPaterno { get; set; }

        public String ApellidoMaterno { get; set; }

        public String Nombres { get; set; }

        public Genero Genero { get; set; }
        
        public int GeneroId { get; set; }
        
        public EstadoCivil EstadoCivil { get; set; }

        public int EstadoCivilId { get; set; }
        
    }
}
