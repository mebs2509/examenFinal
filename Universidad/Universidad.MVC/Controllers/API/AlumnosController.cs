using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Universidad.Context;
using Universidad.Entities;
using Universidad.MVC.DTO;

namespace Universidad.MVC.Controllers.API
{
    public class AlumnosController : ApiController
    {

        private readonly UniversidadDbContext _db = new UniversidadDbContext();

        //CREATE
        //POST/api/alumnos
        [HttpPost]
        public IHttpActionResult CreateAlumno(AlumnoDto alumnoDto) 
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var alumno = Mapper.Map<AlumnoDto, Alumno>(alumnoDto);
            if (alumnoDto == null)
                return BadRequest();

            try
            {
                _db.Alumno.Add(alumno);
                _db.SaveChanges();
                alumnoDto.AlumnoId = alumno.AlumnoId;
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e.ToString());
            }

            return Created(new Uri(Request.RequestUri + "/" + alumno.AlumnoId), alumnoDto);
        }
        
        //Read
        //GET/api/Alumnos
        [HttpGet]
        public IHttpActionResult GetAlumnos() 
        {
            var alumnosDto = _db.Alumno
                .Include(c => c.Genero)
                .Include( c => c.EstadoCivil)
                .ToList()
                .Select(Mapper.Map<Alumno, AlumnoDto>);

            return Ok(alumnosDto);
        }
    }
}
