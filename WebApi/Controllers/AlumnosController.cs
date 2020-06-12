using Microsoft.AspNetCore.Mvc;
using WebApi.Modelos;
using WebApi.Repositorios;


namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            RPAlumno rpAlum = new RPAlumno();
            return Ok(rpAlum.ObtenerAlumno());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
           RPAlumno rpAlum = new RPAlumno();

            var cliAlu = rpAlum.ObtenerAlumno(id);

            if (cliAlu == null)
            {
                var nf = NotFound("El Alumno " + id.ToString() + " no existe.");
                return nf;
            }

            return Ok(cliAlu);
        }

        [HttpPost("agregar")]
        public IActionResult AgregarAlumno(Alumno nuevoalumno)
        {
            RPAlumno rpALum = new RPAlumno();
            rpALum.Agregar(nuevoalumno);
            return CreatedAtAction(nameof(AgregarAlumno), nuevoalumno);
        }
    }
}