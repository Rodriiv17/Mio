﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemplodia4
{
    public class Trabajador : Empleado
    {
        

        public Trabajador(string nombre, string turno) : base(nombre)
        {
            Turno = turno;
        }

        public string Turno { get; set; }

        public override void CalculoVacaciones()
        {
            base.CalculoVacaciones();
            diasVacaciones += 15;
        }
        public override string ToString()
        {
            return $"[ Trabajador. Nombre: {Nombre} "+ 
                $"Turno de: {Turno} "
                ;
            ;
        }
    }
}