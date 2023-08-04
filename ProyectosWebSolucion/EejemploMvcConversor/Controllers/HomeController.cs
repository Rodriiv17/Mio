using EejemploMvcConversor.Models;
using EejemploMvcConversor.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EejemploMvcConversor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServicioMonedas servicioMonedas;

      

        public HomeController(ILogger<HomeController> logger, IServicioMonedas servicioMonedas)
        {
            _logger = logger;
            this.servicioMonedas = servicioMonedas;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Estoy en el index");
            //var serviciomonedas = new ServicioMonedas();
            //var serviciomonedas = new ServicioCriptoMonedas();
            IServicioMonedas serviciomonedas = new ServicioCriptoMonedas();
            var lista = serviciomonedas.ObtenerMonedas();

            return View();

        }
        //

        public IActionResult Privacy()
        {
            MailProduccion crearmail = new MailProduccion();
            crearmail.Desarrollo = new MailDesarrollo();
            crearmail.CorreoOrigen = "pepeluis@hotmail.es";
            crearmail.CorreoDestino = "juanpedro@hotmail.es";
            crearmail.Desarrollo.Descripcion = "Hola Juan este es mi primer correo";
            _logger.LogInformation("Estoy en Privacy");

            IMail nuevomail = new EnvioMail();

            var lista2 = nuevomail.ObtenerMail();
            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}