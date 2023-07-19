namespace EurosyLibras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string monedaorigen;
            string monedadestino;
            double solucion;
            Console.Write("Seleccione la moneda que quiere obtener Libra /L Euros /E Dolares /D ");
            Console.Write(" ");
            monedaorigen = Console.ReadLine();
            if (monedaorigen == "L" || monedaorigen == "E" || monedaorigen == "D") { 
            Console.Write("Seleccione a la moneda que desee cambiar Libra /L Euros /E Dolares /D ");
            Console.Write(" ");
            monedadestino = Console.ReadLine();
            if (monedadestino == "L" || monedadestino == "E" || monedadestino == "D")
                {

                    if (monedaorigen == "E" && monedadestino == "D")
                    {
                        Console.Write("Introduzca Cantidad ");
                        Console.Write(" ");
                        solucion = CambioMoneda.EuroToDolar(Console.ReadLine());
                        Console.WriteLine(Math.Round(solucion, 2));
                    }
                    else if (monedaorigen == "E" && monedadestino == "L")
                    {
                        Console.Write("Introduzca Cantidad ");
                        Console.Write(" ");
                        solucion = CambioMoneda.EuroToLibra(Console.ReadLine());
                        Console.WriteLine(Math.Round(solucion, 2));
                    }
                    else if (monedaorigen == "D" && monedadestino == "E")
                    {
                        Console.Write("Introduzca Cantidad ");
                        Console.Write(" ");
                        solucion = CambioMoneda.DolarToEuro(Console.ReadLine());
                        Console.WriteLine(Math.Round(solucion, 2));
                    }
                    else if (monedaorigen == "D" && monedadestino == "L")
                    {
                        Console.Write("Introduzca Cantidad ");
                        Console.Write(" ");
                        solucion = CambioMoneda.DolarToLibra(Console.ReadLine());
                        Console.WriteLine(Math.Round(solucion, 2));
                    }
                    else if (monedaorigen == "L" && monedadestino == "E")
                    {
                        Console.Write("Introduzca Cantidad ");
                        Console.Write(" ");
                        solucion = CambioMoneda.LibraToEuro(Console.ReadLine());
                        Console.WriteLine(Math.Round(solucion, 2));
                    }
                    else if (monedaorigen == "L" && monedadestino == "D")
                    {
                        Console.Write("Introduzca Cantidad ");
                        Console.Write(" ");
                        solucion = CambioMoneda.LibraToDolar(Console.ReadLine());
                        Console.WriteLine(Math.Round(solucion, 2));
                    }
                }
            }
        }
        }
    }
