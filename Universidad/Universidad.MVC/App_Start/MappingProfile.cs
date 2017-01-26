using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Universidad.Entities;
using Universidad.MVC.DTO;

namespace Universidad.MVC.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Alumno, AlumnoDto>();
            CreateMap<AlumnoDto, Alumno>();

            CreateMap<Genero, GeneroDto>();
            CreateMap<GeneroDto, Genero>();

            CreateMap<EstadoCivil, EstadoCivilDto>();
            CreateMap<EstadoCivilDto, EstadoCivil>();
        }
    }
}