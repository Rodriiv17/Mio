using System;
using System.Collections.Generic;
namespace Coches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string marca;
            string modelo;
            string color;
            int year;
            int i;
            Console.Write("¿cuantos coches vas a querer almacenar?(max 8)");
            int j = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= j; i++)
            {
                Console.Write("Dame una marca a de vehiculo");
                Console.Write(" ");
                marca = Console.ReadLine();
                Console.Write("Dame el modelo del vehiculo");
                Console.Write(" ");
                modelo = Console.ReadLine();
                Console.Write("Dame el color del vehiculo");
                Console.Write(" ");
                color = Console.ReadLine();
                Console.Write("dame el año de compra");
                Console.Write(" ");
                year = Convert.ToInt32(Console.ReadLine());

                var nuevocarro = new CrearCoche();
                {
                    nuevocarro.marca = marca;
                    nuevocarro.modelo = modelo;
                    nuevocarro.color = color;
                    nuevocarro.fechacompra = year;
                }
                CrearCoche[] array1 = new CrearCoche[8];
                array1[i]=(nuevocarro);
                Console.WriteLine(array1[i].marca +" "+ array1[i].modelo + " " + array1[i].color+" "+ array1[i].fechacompra);
                Console.Write(array1[i]);
 
            }
        }
    }
}