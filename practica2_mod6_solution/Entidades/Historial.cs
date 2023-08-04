using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Entidades
{
    public class Historial
    {
        List<Historico> historials = new List<Historico>();
        string path = Environment.CurrentDirectory + "\\historial.json";
       
        public Historial()
        {
            
        }

        public void Cargarhistorial()
        {
            try
            {
                string json = File.ReadAllText("historial.json");
                historials = JsonConvert.DeserializeObject<List<Historico>>(json);
            }
            catch {
                //throw new Exception();
            }

        }
        public void AgregarAlHistorial(Historico historico)
        {
            historials.Add(historico);
            string json = JsonConvert.SerializeObject(historials);
            System.IO.File.WriteAllText(path, json);
            
        }
        public void eliminarhistorial()
        {

            historials.Clear();
            string path = Environment.CurrentDirectory + "\\historial.json";
            File.WriteAllText(path, "[]");



        }

        public void MostrarHistorial()
        {
            Console.WriteLine("=================================================================HISTORIAL======================================================================");
            foreach (var item in historials)
            {
                Console.WriteLine($"================================================================================================================================================ \n" +
                    $" Importe a convertir: {item.Cantidad}   Moneda de origen: {item.MonedaOrigenId}   Moneda de destino: {item.MonedaDestinoId}   Factor: {item.FactorConversion}   Resultado: {item.Resultado}   Fecha: {item.FechaConversion} \n================================================================================================================================================");
            }
        }
    }
}
