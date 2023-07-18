
namespace Vehiculos
{
    internal class Vehiculo
    {
        DateTime P = DateTime.Now;
        int x;

        //public enum Etiquetaeco
        //{
        //    sinetiqueta, etiquetaB,etiquetaC,etiquetaECO,etiquetaCERO
        //}

        public Vehiculo( string marca, int valorbase,DateTime antiguedad, string etiqueta) 
        {
            this.marca = marca;
            this.valorbase = valorbase;
            this.antiguedad = antiguedad;
            this.etiqueta = etiqueta;
        }

        public Vehiculo()
        {
        }

        public string marca { get; set; }
        public int valorbase { get; set; }
        public DateTime antiguedad { get; set; }= DateTime.Now;
        public string etiqueta { get; set; }

        internal void CalcularAntiguedad()
        {
            TimeSpan timeSpan1 = DateTime.Today - antiguedad;
            Console.WriteLine(timeSpan1);
        }

        internal void CalcularEtiqueta()
        {
            switch (etiqueta)
            {
                case "sinetiqueta":
                    valorbase = (int)(valorbase + (valorbase * 0.25));
                    break;
                case "etiquetaB":
                    valorbase = (int)(valorbase + (valorbase * 0.15));
                    break;
                case "etiquetaC":
                    valorbase = (int)(valorbase + (valorbase * 0.10));
                    break;
                case "etiquetaECO":
                    valorbase = (int)(valorbase + (valorbase * 0.05));
                    break;
                case "etiquetaCERO":
                    valorbase = (int)(valorbase);
                    break;

                    

            }
        }
    }
}
