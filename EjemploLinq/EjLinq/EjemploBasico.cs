using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjLinq
{
    public class EjemploBasico
    {
        public EjemploBasico()
        {
        }

        public void Ejecutar()
        {

            string[] niveles = { "Basico", "Intermedio", "Avanzado" };
            int nc = niveles.Count();

            //Selecciona todos lo niveles cuya longitud en caracteres sea mayor que 6 ordenado por nivel
           var listaConsultaForeach = new List<string>();
            foreach (string nivel in niveles)
            {
                if (nivel.Length > 6)
                {
                    listaConsultaForeach.Add(nivel);
                }
               

            }
            // Sintaxis SQL
            // Select nivel from niveles where nivel.length > 6 order by nivel
            
            //ES LO MISMO QUE HACER UN FOREACH
            //1-preparación
            var consultaLinq = from nivel in niveles
                                     where nivel.Length > 6
                                     orderby nivel
                                     select nivel;

            //2-Obtener resultados  CONVERTIMOS EN UNA LISTA LA CONSULTALINQ
            List<string> listaResultados = consultaLinq.ToList();

            //Sintaxis de Metodos
            //1-Preparación
            //Func<string, bool> predicado = nivel => nivel.Length > 6;
            //var consultaLinqMetodos = niveles.Where(predicado);
            //2-Resultados
            var consultaLinqMetodos = niveles.Where(nivel => nivel.Length > 6).OrderBy(nivel => nivel).Select(nivel => nivel);

            //2-Resultados
            List<string> ListaResultadosLingMetodos = consultaLinqMetodos.ToList();
        }
    }
}
