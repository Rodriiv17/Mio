using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEventos
{
    internal class RelojDigital
    {
        public RelojDigital() { }

        internal void Suscribir(Reloj reloj)
        {
            reloj.CambioSegundoEvento += Reloj_CambioSegundoEvento
                ;
        }

        private void Reloj_CambioSegundoEvento(object reloj, InformacionTiempoEventArgs e)
        {
            Console.WriteLine($"HoraActual: {e.Hora.ToString()} : " + 
                                            $"{e.Minuto.ToString()} :" +
                                            $" {e.Segundo.ToString()} ");
        }
    }
}
