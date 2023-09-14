using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {

        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }
        public string Nombre { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public string? Telefono { get; set; }
        public string password{ get; set; }


    }
}
