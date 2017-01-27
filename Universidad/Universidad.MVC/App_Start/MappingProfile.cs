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

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Alumno, AlumnoDto>();
                cfg.CreateMap<AlumnoDto, Alumno>();

                cfg.CreateMap<Genero, GeneroDto>();
                cfg.CreateMap<GeneroDto, Genero>();

                cfg.CreateMap<EstadoCivil, EstadoCivilDto>();
                cfg.CreateMap<EstadoCivilDto, EstadoCivil>();

            });
            
        }
    }
}