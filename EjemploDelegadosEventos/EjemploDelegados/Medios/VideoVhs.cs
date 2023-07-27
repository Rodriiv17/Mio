using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados.Medios
{
    internal class VideoVhs
    {
        public bool ProbarVhs()
        {
            Console.WriteLine("Por favor, ponga el cd en el reproductor");
            //Console.WriteLine("Pulsa el botón de reproducción");
            Console.WriteLine("Indique a continuación si has escuchado algo");

            var result = Console.ReadLine();
            //equivale a if (result=="S")/else
            return result == "S";
        }
        public string listapelicula(string identificador)
        {
            //Console.WriteLine("ESCRIBA EL IDENTIFICADOR: ");
            //identificador = Console.ReadLine();
            return "lista canciones";
        }
    }
}
