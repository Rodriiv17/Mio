using DTOs;
using Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelos;
using Helpers;


namespace Repositorios
{
    public class RepositorioBBDD : IRepositoriosBBDD
    {

        private readonly ContextoConversor db;

        public RepositorioBBDD(ContextoConversor db)
        {
            this.db = db;
        }


        public async Task<IEnumerable<Persona>> GetPersonasAsync()
        {

            
            return await db.Persona.ToListAsync();
        }

        public async Task<Persona> FindUsuarioPoruserNameAsync(string username)
        {
            return await db.Persona.FirstOrDefaultAsync(p => p.UserName.Equals(username));
        }
        public async Task<ActionResult<List<PersonaDTO>>> GetPersonasMayoresDe21()
        {
            // Llama al método GetPersonasAsync para obtener todas las personas
            var personas = await GetPersonasAsync();

            // Obtiene la fecha actual
            var currentDate = DateTime.UtcNow;

            // Filtra las personas mayores de 21 años utilizando GetCurrentAge
            var personasMayoresDe21 = personas.Where(p => p.FechaNacimiento.GetCurrentAge() > 21).ToList();

            // Aquí puedes mapear las personas a DTOs incluyendo la edad
            var personasDTO = personasMayoresDe21.Select(p => new PersonaDTO
            {
                // Mapea las propiedades de Persona a las propiedades de PersonaDTO
                // Por ejemplo:
                Id = p.Id,
                Nombre = p.Nombre,
                Edad = p.FechaNacimiento.GetCurrentAge(), // Calcula la edad aquí
                Telefono = p.Telefono,
                // ... otras propiedades ...
            }).ToList();

            return personasDTO.Take(10).ToList();
        }
        public async Task RegistrarPersona(Persona user)
        {

            db.Add(user);
            await db.SaveChangesAsync();

        }



    }
}