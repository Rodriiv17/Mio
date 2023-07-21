using System;
namespace ejemplodia4 //HERENCIAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empresa softonic = new Empresa("Softonic");
            var juan = new Empleado("juan");
            var maria = new Administrador("Maria",true,"12");

            juan.Jefe = maria;
            
            Trabajador jose = new Trabajador("jose","tardes");
            Externo pepe = new Externo("pepe", softonic);
            jose.Jefe = maria;
            Empleado luis = new Externo("Luis",softonic);
            var lista = new List<Empleado>()
            {
                juan,
                jose,
                maria,
                luis
            };
            IEnumerable<Empleado> listaEmpleadosJ = from empleado in lista
                                                    where empleado.Nombre.StartsWith("j")
                                                    orderby empleado.Nombre
                                                    select empleado;

            foreach (var empleado in lista) 
            {
                //if (empleado.Nombre.StartsWith("j"))
                //{
                 //   Console.WriteLine(empleado.Nombre);
                    empleado.CalculoVacaciones();
               // }
            }

            try
            {
                if (maria.Plaza)
                {
                    Console.WriteLine(maria.plazaparking());
                }
            }
            catch(ErrorBaseDatosExcepcion  ex)
            {
                Console.WriteLine(ex.Mensaje+ " "+ ex.FechaHoraExcepcion);
                
            }

            Console.WriteLine("");
            Console.WriteLine(jose.ToString());
            
            Console.WriteLine(juan.ToString());
            Console.WriteLine(maria.ToString());



        }
    }
}