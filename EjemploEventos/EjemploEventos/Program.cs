﻿namespace EjemploEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- crear instancia del reloj interno (publicador)

            var reloj = new Reloj();
            //2- crear un reloj digital y nos suscribimos (suscriptor)

            var relojDigital = new RelojDigital();
            relojDigital.Suscribir(reloj);

            //Ejecricio
            //Crear un log o registro que guarde
            //cada 10 segundos la fecha y hora

            var log = new Registro();
            log.Suscribir(reloj);


            //3- poner en marcha el reloj
            reloj.IniciarReloj();
            

        
        
        
        }
    }
}