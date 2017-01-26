using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Universidad.Entities;

namespace Universidad.MVC.DTO
{
    public class AlumnoDto
    {
        public int AlumnoId { get; set; }

        public DateTime Created { get; set; }

        public String Codigo { get; set; }

        public String Apellidos { get; set; }

        public String Nombres { get; set; }
              
        public int GeneroId { get; set; }
        
        public GeneroDto Genero { get; set; }

         public int EstadoCivilId { get; set; }

        public EstadoCivilDto EstadoCivil { get; set; }


    }
}