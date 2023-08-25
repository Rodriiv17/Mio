using EejemploMvcConversor.Models;
using Microsoft.AspNetCore.Mvc;

namespace EejemploMvcConversor.Controllers
{
    public class MonedasController : Controller
    {
        private readonly ILogger<MonedasController> _logger;
        private readonly IRepositorioMonedas repositorioMonedas;

        public MonedasController(ILogger<MonedasController> logger, IRepositorioMonedas repositorioMonedas)
        {
            _logger = logger;
            this.repositorioMonedas = repositorioMonedas;
        }


        public IActionResult Index()
        {
            
            IEnumerable<Moneda> lista = repositorioMonedas.ObtenerMonedas();
            return View(lista);
        }
    }
}
