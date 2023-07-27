using DataProcessor;
using Newtonsoft.Json;
using System.Runtime.InteropServices.ObjectiveC;

namespace Importacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string json = @"{
             'Name': 'Bad Boys',
             'ReleaseDate': '1995-4-7T00:00:00',
             'Genres': [
               'Action',
                  'Comedy'
                       ]
                }";

            Movie m = JsonConvert.DeserializeObject<Movie>(json);

            string name = m.Name;
            foreach (var pepe in m.Genres)
            {
                Console.WriteLine(pepe);

            }

           string monedajson = File.ReadAllText("Monedas.json");

            var monedas = JsonConvert.DeserializeObject<List<dynamic>>(monedajson);
            dynamic monedaOtra = null;
            foreach (var moneda in monedas)
            {
                if (moneda.otramoneda != null)
                {
                    monedaOtra = moneda;
                    break;
                }
                
            }
                if (monedaOtra != null)
                {
                    Console.WriteLine(monedaOtra.nombre + " " + monedaOtra.codigo + " " + monedaOtra.valorEnDolares+ " "+ monedaOtra.otramoneda);
                }

            var monedas2= JsonConvert.DeserializeObject<List<Moneda>>(monedajson);
            foreach (var moneda in monedas2)
            {
                Console.WriteLine("Nombre: " + moneda.nombre);
                Console.WriteLine("Código: " + moneda.codigo);
                Console.WriteLine("Valor en dólares: " + moneda.valorEnDolares);

               

                Console.WriteLine("--------------------------");
            }

            // Bad Boys
        }
    }
}