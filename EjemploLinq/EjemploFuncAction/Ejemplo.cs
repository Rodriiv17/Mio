using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjemploFuncAction
{
    public class Ejemplo
    {
        public Action<int> AccionProperty { get; set; }
        internal void EjemploAction()
        {
            //Llamar a TestAction pasandole metodo ccomo parametro
            TestAction(Accion, 1);

            //Llamar a TestAction escribiendo la expresion lambda como parametro entre los  dos parentesis
            //TestAction(parametro1,1);
            TestAction((x) =>
            {
                Console.WriteLine($"En el metodo Accion {x}");
            }
                , 1);
            //1-Crear una variable que almacene la accion 
            // 2-Llamar a TestAction pasandole la variable y el valor 1
            Action<int> accion = (y) =>
            {
                Console.WriteLine($"En el metodo Accion {y}");

             };

            TestAction(accion, 1);

            //Lista de Acciones
            //
            List<Action<int>> listaAcciones = new List<Action<int>>();

            listaAcciones.Add( accion );
            listaAcciones.Add(Accion);

            foreach (var elementoAccion in listaAcciones)
            {
                elementoAccion(1);
            }

        }


        //Metodo que recibe un Action<int> y un int
        //Dentro ha de llamar al Action pasado como parametro

        public void TestAction (Action<int> accion, int numero)
        {
            accion(numero);
        }

        public void Accion (int numero) 
        {
        Console.WriteLine($"En el metodo accion {numero}");
        }





















        //internal void EjemploDelegados1()
        //{
        //    // Expresión Lambda mediante Func<>

        //    Func<string> holaMundoExpresion =

        //     //parametros
        //     ()
        //     //operador lambda 
        //     =>
        //     //Delegado / Método anónimo / Expresión 
        //     " Hola Mundo !!!!";
        //    Console.WriteLine(holaMundoExpresion);  
        //    Console.WriteLine(holaMundoExpresion());

        //    //Expresion Lambda mediante Bloque Func<>
        //    Func<string> holaMundoBloque =

        //     //parametros
        //     ()
        //     //operador lambda 
        //     =>
        //     //Delegado / Método anónimo 
        //     {
        //         var cadena = " Hola Mundo!!!!!";
        //         return cadena;
        //     };
        //    Console.WriteLine(holaMundoBloque());

        //    //Crear una expresion lambda que sume dos numeros
        //    //Console.WriteLine(sumar(10, 20));
        //    Func<int, int, int> sumar = 
        //     //parametros
        //     (x,y)
        //     //operador lambda 
        //     =>(int)(x+y);
        //     //Delegado / Método anónimo
        //     {
        //        Console.WriteLine(sumar(10, 20));
        //     }


        //}
    }
}
