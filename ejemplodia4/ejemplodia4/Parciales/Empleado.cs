using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemplodia4
{
    public partial class Empleado
    {
        public string? Telefono { get; set; }
        public Empleado Jefe { get; set; }

      
    }
}