
namespace EejemploMvcConversor.Models
{
    public class MailProduccion 
    {
        public int Id { get; set; }
        public string CorreoOrigen { get; set; }
        public string CorreoDestino { get; set; }

        public MailDesarrollo Desarrollo { get; set; }


    }
}
