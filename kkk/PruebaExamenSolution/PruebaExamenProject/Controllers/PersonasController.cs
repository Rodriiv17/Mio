using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Entidades;

using AutoMapper;
using Repositorios;
using DTOs;

namespace PruebaExamenProject.Controllers
{

    [Route("api/personas")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        
        private readonly IMapper mapper;
        private IConfiguration configuration;
        private IRepositoriosBBDD repodb;

        public PersonasController(IMapper mapper,IConfiguration configuration,IRepositoriosBBDD repodb)
        {
            this.mapper = mapper;
            this.configuration = configuration;
            this.repodb = repodb;
        }

        [HttpGet]
        [HttpHead]

        public async Task<ActionResult<List<PersonaDTO>>> GetPersonas()
        {
            

            IEnumerable<Persona> personaFromRepo = await repodb.GetPersonasAsync();

            return Ok(mapper.Map<List<PersonaDTO>>(personaFromRepo));
        }

        [HttpGet("mayoresDe21")]
        public async Task<ActionResult<List<PersonaDTO>>> GetPersonasMayoresDe21()
        {
            var personasDTO = await repodb.GetPersonasMayoresDe21();

            // Devuelve solo los 3 primeros elementos de la lista
            return personasDTO;
        }
        [HttpPost("registro")]
        public async Task<ActionResult> Register([FromBody] PersonaCrearDTO parametros)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // Hashear la contraseña antes de guardarla en la base de datos
                parametros.Password = Operaciones.Utilidades.HashearMD5(parametros.Password);

                // Mapear el DTO a una entidad Persona
                var persona = new Persona
                {
                    UserName = parametros.UserName, // Añadir UserName
                    Nombre = parametros.Nombre,
                    FechaNacimiento = parametros.FechaNacimiento,
                    Telefono = parametros.Telefono,
                    password = parametros.Password


                    // Otras propiedades
                };

                // Verificar si el UserName ya existe
                var existingUser = await repodb.FindUsuarioPoruserNameAsync(persona.UserName);

                if (existingUser == null)
                {
                    // Registrar la nueva persona en la base de datos
                    await repodb.RegistrarPersona(persona);
                    return NoContent(); // El registro fue exitoso
                }

                return BadRequest("UserName ya existe. Prueba con otro.");
            }
            catch (Exception ex)
            {
                // Maneja las excepciones aquí y devuelve una respuesta de error adecuada.
                // Puedes registrar errores o tomar acciones adicionales según sea necesario.
                return StatusCode(500, $"Error al registrar la persona: {ex}");
            }
        }




    }
}
