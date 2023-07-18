
namespace Vehiculos
{
    internal class Vehiculo
    {
        DateTime P = DateTime.Now;
        int x;
        int pepe;
        //public enum Etiquetaeco
        //{
        //    sinetiqueta, etiquetaB,etiquetaC,etiquetaECO,etiquetaCERO
        //}

        public Vehiculo( string marca, int valorbase,int antiguedad, string etiqueta) 
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
        public int antiguedad { get; set; }
        public string etiqueta { get; set; }

        internal void CalcularAntiguedad()
        {
            var x = DateTime.Now.Year - antiguedad;
            double pepe = valorbase+( x * 0.01);
            Console.WriteLine(pepe);
        }
        //holalaa
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
