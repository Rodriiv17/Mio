using Domain.IRepositories;
using Domain.IServices;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PersonaService : IPersonaService
    {
        private readonly IPersonaRepository _personaRepository;
        public PersonaService(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }
        public async Task<IEnumerable<Persona>> GetUltimasPersonasMas21Anios()
        {
            return await _personaRepository.GetUltimasPersonasMas21Anios();
        }

        public async Task GuardarPersona(Persona persona)
        {
            await _personaRepository.GuardarPersona(persona);
        }
    }
}
