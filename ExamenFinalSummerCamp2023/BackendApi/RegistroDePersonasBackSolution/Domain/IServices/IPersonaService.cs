using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IServices
{
    public interface IPersonaService
    {
        Task<IEnumerable<Persona>> GetUltimasPersonasMas21Anios();
        Task GuardarPersona(Persona persona);

    }
}
