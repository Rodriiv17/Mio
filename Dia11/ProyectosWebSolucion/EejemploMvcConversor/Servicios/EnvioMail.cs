using EejemploMvcConversor.Models;

namespace EejemploMvcConversor.Servicios
{
    public class EnvioMail : IMail
    {
        
        public List<MailProduccion> Mails { get; set; }


        public List<MailProduccion> ObtenerMail()
        {
            return Mails;
        }

 
    }
}
