using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Entities
{
    public class EstadoCivil
    {
        public EstadoCivil()
        {
            Alumnos = new List<Alumno>();
        }

        [DisplayName("Estado Civil")]
        public int Id { get; set; }

        [DisplayName("Estado Civil")]
        public String Descripcion { get; set; }

        public List<Alumno> Alumnos { get; set; }

    }
}
