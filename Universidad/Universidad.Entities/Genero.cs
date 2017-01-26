using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Entities
{
    public class Genero
    {
        public Genero()
        {
            Alumnos = new List<Alumno>();
        }

        [DisplayName("Genero")]
        public int Id { get; set; }
        
        [DisplayName("Genero")]
        public String Descripcion { get; set; }

        public List<Alumno> Alumnos { get; set; }

      }
}
