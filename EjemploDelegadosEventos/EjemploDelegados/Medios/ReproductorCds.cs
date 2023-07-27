using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados.Medios
{
    public class ReproductorCds
    {
        public bool ProbarCd()
        {
            Console.WriteLine("Por favor, ponga el cd en el reproductor");
            Console.WriteLine("Pulsa el botón de reproducción");
            Console.WriteLine("Indique a continuación si has escuchado algo");

            var result = Console.ReadLine();
            //equivale a if (result=="S")/else
            return result == "S";
            // CDs-> Mostrar lista de canciones 
           

        }
        public string Listacanciones(string identificador)
        {
            return "lista de canciones";
        }

    }
}
