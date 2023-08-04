using Entidades;
using Newtonsoft.Json;
using System.Numerics;
using static API_Conversor.JsonFormat;

namespace Operaciones
{
    public class Conversor
    {
        public List<Moneda> ListaMonedas { get; set; }
        public List<Factor> ListaFactores { get; set; }

        

        public Conversor()
        {
            //listaMonedas = new List<Moneda>() { new Moneda("EUR", "euros"), new Moneda("USD", "dolares"), new Moneda("GBP", "libras") };
            //listaFactores = new List<Factor>() { new Factor("EUR", "USD", 1.12), new Factor("USD", "GBP", 0.77), new Factor("GBP", "EUR", 0.87) };
            ListaMonedas = new List<Moneda>();
            ListaFactores = new List<Factor>();
        }
        public void cargarMonedas(Root arrayJson)
        {   System.Reflection.PropertyInfo[] lista = API_Conversor.ArrayJson.ArrayJson_file(arrayJson);
            foreach(System.Reflection.PropertyInfo item in lista)
            {
                
                var moneda = new Moneda(item.Name);
                var facor = new Factor(item.Name, (double)item.GetValue(arrayJson.conversion_rates));
                ListaMonedas.Add(moneda);
                ListaFactores.Add(facor);

            }
        }


        public static double CambioMoneda(double importe, string moneda_o, string moneda_d)
        {
            Conversor conversor = new Conversor();
            //Cargamos el fichero
            string json = File.ReadAllText("monedas.json");
            Root array_api = JsonConvert.DeserializeObject<Root>(json);
            conversor.cargarMonedas(array_api);
            bool moneda_o_exist = false;
            bool moneda_d_exist = false;
            double fact_o=0;
            double fact_d=0;
            //busca que exista las dos monedas y saca el factor de cada una respecto al USD
            foreach (var item in conversor.ListaFactores)
            {
                if (item.Id == moneda_o){
                    moneda_o_exist = true;
                    fact_o = item.Fact;   
                }if (item.Id == moneda_d) {
                    moneda_d_exist = true;
                    fact_d=item.Fact; 
                }if (moneda_d_exist && moneda_o_exist) {
                    break;
                }
            }if (moneda_d_exist && moneda_o_exist)
            {   //Para sacar la relacción final se divide el factor de la moneda destino con el de la moneda origen.
                double fact_total = fact_d / fact_o;
                return importe * fact_total;
            }
            else {

                Console.WriteLine("Alguna de las monedas introducidas no existe.");
                return 0;
            }
                



        }

     }
}

