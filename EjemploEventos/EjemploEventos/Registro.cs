namespace EjemploEventos
{
    internal class Registro
    {
        DateTime diff;
        public Registro()
        {
        }

        internal void Suscribir(Reloj reloj)
        {
            reloj.CambioSegundoEvento += Reloj_CambioSegundoEvento;


        }
        //
        private void Reloj_CambioSegundoEvento(object reloj, InformacionTiempoEventArgs e)
        {

                DateTime actualdate =  DateTime.Now;

                TimeSpan resta = actualdate - diff;

                if (resta.Seconds > 9)
            {
                Console.WriteLine(" Año: " + DateTime.Now.Year + " Mes: " + DateTime.Now.Month + " Dia: " + DateTime.Now.Day + " Hora: " + e.Hora.ToString());
                diff = DateTime.Now;
            } 
               
               

            // TimeSpan ts = TimeSpan.FromSeconds(10);

                //if (e.Segundo == 10 || e.Segundo == 20 || e.Segundo == 30 || e.Segundo == 40 || e.Segundo == 50 || e.Segundo == 0 ) {
                //if (e.Segundo == currentSecond)
                //{
                //Console.WriteLine(" Año: " + DateTime.Now.Year + " Mes: " + DateTime.Now.Month + " Dia: " + DateTime.Now.Day + " Hora: " + e.Hora.ToString());
                //}
                //    //Console.WriteLine(" ");
                //}




        }

    }
}