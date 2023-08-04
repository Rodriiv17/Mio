using EejemploMvcConversor.Models;

namespace EejemploMvcConversor.Servicios
{
    namespace EjemploMvcConversor.Servicios
    {
        public class ServicioMonedas : IServicioMonedas
        {

            public List<Moneda> Monedas { get; set; }


            public List<Moneda> ObtenerMonedas()
            {
                return Monedas;
            }
        }
    }

}
