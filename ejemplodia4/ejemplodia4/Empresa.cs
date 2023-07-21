using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemplodia4
{
    public class Empresa
    {
        public Empresa(string nombreempresa)
        {
            Nombreempresa = nombreempresa;
        }

        public string Nombreempresa { get; set; }
    }
}