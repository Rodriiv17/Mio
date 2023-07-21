using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemplodia4
{
    public class Administrador : Empleado
    {
        string aux;
        public Administrador(string nombre, Boolean sitieneplaza, string numeroplaza) : base(nombre)
        {
            Plaza = sitieneplaza;
            Numeroplaza = numeroplaza;
        }

        public bool Plaza { get; set; }
        public string Numeroplaza { get; }

        public string plazaparking()
        {
            throw new ErrorBaseDatosExcepcion("Error base de datos", DateTime.Now);
            return Plaza ? "Plaza Numero 1" : " No tiene Plaza";
        }

        public  bool Tieneparking()
        {
            if (Plaza)
            {
                Console.WriteLine("El admin tiene plaza de garaje");
            }
            else
            {
                Console.WriteLine("El admin no tiene plaza de garaje");
            }
            return Plaza;
        }
        public override void CalculoVacaciones()
        {
            diasVacaciones += 9;
        }
        
        public override string ToString()
        {

            if (Plaza)
            {
                return $"[ Empleado. Nombre: {Nombre} " +
                    $"el numero de plaza es : {Numeroplaza}";
            }
            else
            {
                return $"[ Empleado. Nombre: {Nombre} " +
                   $"no tiene plaza";
            }
           //dd
               

        }


    }
}