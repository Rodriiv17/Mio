using Domain.IRepositories;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly ApplicationDbContext _context;
        public PersonaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Persona>> GetUltimasPersonasMas21Anios()
        {
            await _context.SaveChangesAsync();
            return await _context.Personas.FromSqlRaw($"EXEC ObtenerUltimasPersonasMayoresDe21").ToListAsync();
        }

        public async Task GuardarPersona(Persona persona)
        {
            if (persona == null)
            {
                throw new ArgumentNullException(nameof(persona));
            }
            _context.Add(persona);
            await _context.SaveChangesAsync();
        }
    }
}
