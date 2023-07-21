using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemplodia4
{
    public class Externo : Empleado
    {
        public Externo(string nombre,Empresa empresa) : base (nombre)
        {
            Nombre = nombre;
            Empresa = empresa;
        }

        public string Nombre { get; set; }
        public Empresa Empresa { get; set; }
    }
}