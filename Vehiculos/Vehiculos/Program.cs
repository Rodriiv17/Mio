namespace Vehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coche1 = new Vehiculo();
            coche1.marca = "ferrari";
            coche1.valorbase = 1000;
            coche1.antiguedad = new DateTime(2021);
            coche1.etiqueta = "sinetiqueta";

            var coche2 = new Vehiculo();
            coche2.marca = "opel";
            coche2.valorbase = 1000;
            coche2.antiguedad = new DateTime(1998);
            coche2.etiqueta = "etiquetaB";

            var coche3 = new Vehiculo();
            coche3.marca = "fiat";
            coche3.valorbase = 1000;
            coche3.antiguedad = new DateTime(1996);
            coche3.etiqueta = "etiquetaECO";

            var numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            numeros.Add(9);

            var lista = new List<Vehiculo>();
            lista.Add(coche1);
            lista.Add(coche2);
            lista.Add(coche3);

            foreach (var vehiculo in lista)
            {
                //
                vehiculo.CalcularAntiguedad();
                vehiculo.CalcularEtiqueta();

            }
            Console.WriteLine(coche1.valorbase);
            Console.WriteLine(coche2.valorbase);
            Console.WriteLine(coche3.valorbase);

        }
    }
}