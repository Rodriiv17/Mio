using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Moneda
    {
        public string Nombre { get; set; }
    }
    //1-Ruta
    //  [Route("api/[controller]")]
    [Route("api/Monedas")]
    //2-Controlador API
    [ApiController]
    public class MonedasController : ControllerBase //3-Hereda de controlador API
    {
        //Verbo Http
        [HttpGet]
        // Devuelve ActionResult<tipo>
        public ActionResult<IEnumerable<Moneda>> ObtenerMonedas()
        {
            var lista = new List<Moneda>
            {
                new Moneda { Nombre = "Euro"}
            };
            //Devolvewr resultado y codigo de estado
            return Ok(lista);
        }
    }
}
