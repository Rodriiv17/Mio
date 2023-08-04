using API_Conversor;
using Entidades;
using Newtonsoft.Json;
using Operaciones;
using static API_Conversor.JsonFormat;

namespace practica2_mod6
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            int x;
            Menu nuevomenu = new Menu();
            Historial historial = new Historial();
            bool salir = false;

            historial.Cargarhistorial();

            while (!salir)
            {
                nuevomenu.MostrarMenuPrincipal();
                string A = Console.ReadLine();
                switch (A)
                {
                    case "1":

                string eleccion;
                string moneda_o = "USD";//Moneda de referencia

                //Para pillar el directorio donde esta json.
                string path = Environment.CurrentDirectory + "\\monedas.json";
                ArrayJson arrayJson = new ArrayJson();


                //Sacas el arrayJson del archivo json creado con la info de la API
                Root jsonDeserializado = new Root();
                bool existe_json_moneda;
                try
                {
                    string json = File.ReadAllText("monedas.json");
                    jsonDeserializado = JsonConvert.DeserializeObject<Root>(json);
                    existe_json_moneda = true;

                } catch (Exception ex)
                {
                    existe_json_moneda = false;
                }


                        //

                if (!existe_json_moneda || arrayJson.ComprobarFecha(jsonDeserializado))
                {

                    //+Llamar a la API
                    try
                    {
                        ApiService apiService = new ApiService(moneda_o);
                        string responseData = await apiService.CallApiAsync();
                        System.IO.File.WriteAllText(path, responseData);
                        //Console.WriteLine(responseData);
                        jsonDeserializado = JsonConvert.DeserializeObject<Root>(responseData);//Con el Json convertido a un objeto


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                //string conv_text= "CONVERSOR DE DIVISA";

                API_Conversor.ArrayJson.MostrarListaMonedas(jsonDeserializado);
                Console.WriteLine();



                while (true)

                {
                    var moneda = new Moneda();
                    Conversor conversor = new Conversor();
                    string monedaOrigenId = "";
                    string monedaDestinoId = "";

                    //Coger la moneda de origen
                    Console.Write("\n   ");
                    eleccion = Console.ReadLine().ToUpper(); ;
                    bool acierto = API_Conversor.ArrayJson.ComprobarDivisa(eleccion, jsonDeserializado);
                    while (!acierto)
                    {
                        Console.WriteLine("Escoja entre las opciones indicadas.\n ");
                        Console.Write("\n   ");
                        eleccion = Console.ReadLine().ToUpper(); ;
                        acierto = API_Conversor.ArrayJson.ComprobarDivisa(eleccion, jsonDeserializado);
                    }
                    monedaOrigenId = eleccion;



                    //Coger la moneda de destino
                    Console.WriteLine("Indique el tipo de divisa al que desea convertir: \n ");

                    API_Conversor.ArrayJson.MostrarListaMonedas(jsonDeserializado);

                    Console.WriteLine();
                    Console.Write("\n   ");
                    eleccion = Console.ReadLine().ToUpper();
                    acierto = API_Conversor.ArrayJson.ComprobarDivisa(eleccion, jsonDeserializado);
                    while (!acierto)
                    {
                        Console.WriteLine("Escoja entre las opciones indicadas.\n ");
                        Console.Write("\n   ");
                        eleccion = Console.ReadLine().ToUpper(); ;
                        acierto = API_Conversor.ArrayJson.ComprobarDivisa(eleccion, jsonDeserializado);
                    }
                    monedaDestinoId = eleccion;



                    //Coger importe
                    Console.WriteLine("\nIndique el importe que desea convertir: ");
                    Console.Write("\n   ");
                    double.TryParse(Console.ReadLine(), out double importe);
                    var type = typeof(double);

                    while (importe.GetType() != type || importe == 0)
                    {
                        Console.WriteLine("Introduzca un importe válido.\n ");
                        Console.Write("\n   ");
                        double.TryParse(Console.ReadLine(), out importe);
                    }

                    double resultado_int = Conversor.CambioMoneda(importe, monedaOrigenId, monedaDestinoId);
                    double resultado = resultado_int.Truncate(2);
                    string fecha = DateTime.Now.ToString();
                    double factor_redondeado = (resultado_int / importe).Truncate(2);
                    Historico historico = new Historico(monedaOrigenId, monedaDestinoId, factor_redondeado, importe, resultado, fecha);
                    historial.AgregarAlHistorial(historico);


                    Console.WriteLine($" \n El restultado es: {resultado} {monedaDestinoId}\n ");
                    historial.MostrarHistorial();


                    //VOLVER A MOSTRAR LA LISTA DE MONEDAS
                    Console.WriteLine(" \n Indique el tipo de divisa: \n ");
                    break;
                    //API_Conversor.ArrayJson.MostrarListaMonedas(jsonDeserializado);
                }
                        break;
                    case "2":

                        string json2 = File.ReadAllText("monedas.json");
                        Root jsonDeserializado2 = JsonConvert.DeserializeObject<Root>(json2);
                        API_Conversor.ArrayJson.MostrarListaMonedas(jsonDeserializado2);
                        break;
                    case "3":

                        historial.Cargarhistorial();
                        historial.MostrarHistorial();

                        break;
                    case "4":


                        historial.eliminarhistorial();
                        historial.MostrarHistorial();
                        Console.WriteLine("HISTORIAL ELIMINADO");

                        break;
                    case "5":
                        salir = true;
                        Console.WriteLine("GRACIAS POR UTILIAR EL CONVERSOR");
                        break;
                    default:
                        Console.WriteLine("ERROR, ESCRIBA UN NUMERO DEL 1 AL 5");
                        break;
                }


            }



        }



    }
}