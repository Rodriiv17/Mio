using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PersonaGetDTO
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public int anios { get; set; }
        public string? Telefono { get; set; }
    }
}
