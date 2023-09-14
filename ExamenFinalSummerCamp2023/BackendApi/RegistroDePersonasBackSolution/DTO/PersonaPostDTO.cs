using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PersonaPostDTO
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string? Telefono { get; set; }
    }
}
