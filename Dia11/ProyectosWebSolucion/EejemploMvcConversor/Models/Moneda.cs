using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EejemploMvcConversor.Models
{
    //[Table("Monedas")]
    public class Moneda
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(3)]
        public string CodigoMoneda { get; set; }

        public string? Descripcion { get; set; }

       
    }
}
