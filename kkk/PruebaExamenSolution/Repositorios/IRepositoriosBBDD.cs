using DTOs;
using Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
    public interface IRepositoriosBBDD
    {
        Task<IEnumerable<Persona>> GetPersonasAsync();
        Task<ActionResult<List<PersonaDTO>>> GetPersonasMayoresDe21();
        Task RegistrarPersona(Persona user);
        Task<Persona> FindUsuarioPoruserNameAsync(string username);

    }
}
