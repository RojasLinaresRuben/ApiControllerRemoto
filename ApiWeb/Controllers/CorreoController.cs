using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiWeb.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    [EnableCors]
    public class CorreoController : ControllerBase
    {
        [HttpGet]
        public object GetPersona()
        {
           
            Persona persona = new Persona {
                Apellido = "Rojas",
                Edad = 32,
                Nombre = "Ruben"
            };
            return persona;
        }

        //[HttpGet]
        //public object GetAlumno(int id)
        //{
        //    return "no tenemos nada que ocultar";
        //}
    }
}