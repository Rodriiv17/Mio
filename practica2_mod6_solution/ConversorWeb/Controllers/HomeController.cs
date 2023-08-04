using ConversorWeb.Models;
using Entidades;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using API_Conversor;
using static API_Conversor.JsonFormat;
using Operaciones;

namespace ConversorWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //je
        public IActionResult Index()
        {
            
            ViewBag.saludo = "HOLA MUNDO";
            ViewBag.fecha = DateTime.Now;

            ViewBag.cambio = Conversor.CambioMoneda(54, "USD", "EUR");

            
            //ViewBag.eje8 = eje8;

            return View();
        }
        public IActionResult ListaMonedas()
        {
            ArrayJson json_func = new ArrayJson();
            json_func.Ejecutar();
            Root jsonDeserializado = json_func.DevolverJson();
            ViewBag.listamonedas = json_func.MostrarListaMonedas();
            return View();
        }
        public IActionResult Historial()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}