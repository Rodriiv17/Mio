using EjemploDelegados.Medios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados
{
    internal class InventarioMedios
    {
        public delegate bool ProbarMediosDelegado();

        //Delegado para mostrar info del medio
        public delegate string InfoMedioDelegado(string id);
        
        public void ResultadoProbarMedios(ProbarMediosDelegado probarMediosDelegado)
        {
            //1- Recibir el medio a probar
            //2- Probar el medio
            //3- Si  el medio se ha podido reproducir
            //    indicar como archivarlo

            var resultadoPrueba = probarMediosDelegado();

            if (resultadoPrueba)
            {
                Console.WriteLine("El medio funcoina, " + "hay que agregarlo al inventario");

            }
            else
            {
                Console.WriteLine("El medio no funciona, destruitrlo");
            }
            //var tipo = medio.GetType().FullName;
            //if (tipo== "Tocadiscos")
            //{
            //    var obj = (Tocadiscos)medio;
            //    if(obj.ProbarVinilos())
            //    {
            //        Console.WriteLine("instruciones para almacenar vinilo");
            //    }
            //}

        }

        public void ResultadoInfoMedioDelegado(InfoMedioDelegado infoMedioDelegado, string id)
        {
            
            string resultadoinfo = infoMedioDelegado(id);
            Console.WriteLine(resultadoinfo);
            //if (resultadoinfo == "1234")
            //{
            //    Console.WriteLine("lista canciones...");
            //}
            //else
            //{
            //    Console.WriteLine("ERROR");
            //}
        }
    }
}
