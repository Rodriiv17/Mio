
namespace EurosyLibras
{
    internal class CambioMoneda
    {
        public static double EuroToDolar(string euro1)
        {
            double cambio = Double.Parse(euro1);
            double dolar = 1.2*cambio;
            return dolar;
        }
        public static double EuroToLibra(string euro2)
        {
            double cambio = Double.Parse(euro2);
            double libra = 0.8 * cambio;
            return libra;
        }
        public static double DolarToEuro(string dolar1)
        {
            double cambio = Double.Parse(dolar1);
            double euro = 1.2 * cambio;
            return euro;

        }
        public static double DolarToLibra(string dolar2)
        {
            double cambio = Double.Parse(dolar2);
            double libra = 0.6 * cambio;
            return libra;

        }
        public static double LibraToEuro(string libra1)
        {
            double cambio = Double.Parse(libra1);
            double euro = 0.8 * cambio;
            return euro;

        }
        public static double LibraToDolar(string libra2)
        {
            double cambio = Double.Parse(libra2);
            double dolar = 1.2 * cambio;
            return dolar;

        }
    }
}
