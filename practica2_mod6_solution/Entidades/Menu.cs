using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Menu
    {
        public void MostrarMenuPrincipal()
        {
            Console.WriteLine();
            string conv_text = "   ____    ___    _   _  __     __  _____   ____    ____     ___    ____      ____    _____     ____    ___  __     __  ___   ____       _    \r\n  / ___|  / _ \\  | \\ | | \\ \\   / / | ____| |  _ \\  / ___|   / _ \\  |  _ \\    |  _ \\  | ____|   |  _ \\  |_ _| \\ \\   / / |_ _| / ___|     / \\   \r\n | |     | | | | |  \\| |  \\ \\ / /  |  _|   | |_) | \\___ \\  | | | | | |_) |   | | | | |  _|     | | | |  | |   \\ \\ / /   | |  \\___ \\    / _ \\  \r\n | |___  | |_| | | |\\  |   \\ V /   | |___  |  _ <   ___) | | |_| | |  _ <    | |_| | | |___    | |_| |  | |    \\ V /    | |   ___) |  / ___ \\ \r\n  \\____|  \\___/  |_| \\_|    \\_/    |_____| |_| \\_\\ |____/   \\___/  |_| \\_\\   |____/  |_____|   |____/  |___|    \\_/    |___| |____/  /_/   \\_\\\r\n                                                                                                                                              ";
            Console.WriteLine(conv_text);
            Console.WriteLine();
            Console.WriteLine("SELECCIONE UNA OPCIÓN");
            Console.WriteLine(" ");
            Console.WriteLine("1-CONVERSOR DE MONEDAS");
            Console.WriteLine(" ");
            Console.WriteLine("2-LISTADO DE MONEDAS");
            Console.WriteLine(" ");
            Console.WriteLine("3-HISTORIAL");
            Console.WriteLine(" ");
            Console.WriteLine("4-BORRAR HISTORIAL");
            Console.WriteLine(" ");
            Console.WriteLine("5-SALIR");
        }

    }
}
