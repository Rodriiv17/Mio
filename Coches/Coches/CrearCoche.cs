
namespace Coches
{
    public class CrearCoche
    {

        public CrearCoche() { }
        public CrearCoche(string marca, string modelo, string color, int fechacompra)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.fechacompra = fechacompra;
        }

        public string marca { get; set; }
        public string modelo { get; set; }

        public string color { get; set; }

        public int fechacompra { get; set; }


    }
}
