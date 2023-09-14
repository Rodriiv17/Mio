using AutoMapper;
using Domain.IServices;
using Domain.Model;
using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Api.Controllers
{
    [Route("api/personas")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService _personaService;
        private readonly IMapper _mapper;


        public PersonaController(IPersonaService personaService, IMapper mapper) 
        {
            _personaService = personaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonaGetDTO>>> GetPersonas()
        {
            try
            {

                IEnumerable<Persona> personas = await _personaService.GetUltimasPersonasMas21Anios();
                if (personas == null)
                {
                    return NotFound(new { message = "No existen usuarios mayores de 21 años" });
                }
                List<PersonaGetDTO> p = _mapper.Map<List<PersonaGetDTO>>(personas);
                return Ok(p);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.GetType() + " - ERROR DE SERVIDOR " });
            }

        }


        [HttpPost]
        public async Task<ActionResult> GuardarHistorial([FromBody] PersonaPostDTO personaDTO)
        {
            try
            {
                Persona historialModel = _mapper.Map<Persona>(personaDTO);

                await _personaService.GuardarPersona(historialModel);
                return Ok(new { message = "Registro de Historial guardado con exito" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.GetType() + " - ERROR DE SERVIDOR " });
            }
        }
    }
}
