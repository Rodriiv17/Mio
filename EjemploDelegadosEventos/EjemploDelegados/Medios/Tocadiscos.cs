using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados.Medios
{
    internal class Tocadiscos
    {
        //bool
        public bool ProbarVinilos()
        {

            Console.WriteLine("Por favor, ponga el cd en el reproductor");
            //Console.WriteLine("Pulsa el botón de reproducción");
            Console.WriteLine("Indique a continuación si has escuchado algo");

            var result = Console.ReadLine();
            //equivale a if (result=="S")/else
            return result == "S";

        }
        // vinilo -> Mostrar lista de canciones contraportada
        public string ObtenerCancionesDisco(string codigoBarras)
        {
            //Buscar en BBDD CodigoBarras
            //Devolver resultado
            return "Lista de canciones estan en la contraportada";

        }

    }
}
