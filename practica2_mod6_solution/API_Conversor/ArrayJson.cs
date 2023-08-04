using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static API_Conversor.JsonFormat;

namespace API_Conversor
{
    public class ArrayJson
    {
        private readonly string monedaReferencia;
        private readonly string pathArchivoJson = Environment.CurrentDirectory + "\\monedas.json";
        private ArrayJson arrayJson;
        private Root jsonDeserializado;
        public static System.Reflection.PropertyInfo[] ArrayJson_file(Root jsonDeserializado)
        {
            System.Reflection.PropertyInfo[] propiedades = jsonDeserializado.conversion_rates.GetType().GetProperties();
            return propiedades;
        }

        public ArrayJson()
        {
            
        }

        public  bool ComprobarFecha(Root jsonDeserializado) {

            var fecha = jsonDeserializado.time_next_update_unix;
            var fechaActual = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            if (fechaActual> fecha)
            {
                return true;
            }

            return false;
        }




        public static bool ComprobarDivisa(string eleccion, Root jsonDeserializado)
        {
            var lista = API_Conversor.ArrayJson.ArrayJson_file(jsonDeserializado);
            foreach (var item in lista)
            {
                if(item.Name == eleccion)
                {
                    return true;
                }
             
            }
            return false;
        }
        //public void Ejecutar()
        //{
        //    bool existeJsonMoneda;

        //    try
        //    {
        //        string json = File.ReadAllText(pathArchivoJson);
        //        this.jsonDeserializado = JsonConvert.DeserializeObject<Root>(json);
        //        existeJsonMoneda = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        existeJsonMoneda = false;
        //    }

        //    if (!existeJsonMoneda || ComprobarFecha(this.jsonDeserializado))
        //    {
        //        try
        //        {
        //            LlamarApiYGuardarEnJson().Wait();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }
        //    }
        //}
        public Root DevolverJson()
        {
            Root json_file = this.jsonDeserializado;

            return json_file;
        }
        public static void MostrarListaMonedas(Root jsonDeserializado) {
            System.Reflection.PropertyInfo[] lista =API_Conversor.ArrayJson.ArrayJson_file(jsonDeserializado);
            foreach (System.Reflection.PropertyInfo item in lista) { 
            
                Console.Write($"   {item.Name}");
                //Sacar el valor -> item.GetValue(jsonDeserializado.conversion_rates)
            }
            //private async Task LlamarApiYGuardarEnJson()
            //{
            //    try
            //    {
            //        ApiService apiService = new ApiService(monedaReferencia);
            //        string responseData = await apiService.CallApiAsync();
            //        File.WriteAllText(pathArchivoJson, responseData);
            //        this.jsonDeserializado = JsonConvert.DeserializeObject<Root>(responseData);
            //    }



        }
    }
}
