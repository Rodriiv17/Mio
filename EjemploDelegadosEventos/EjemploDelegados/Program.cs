using EjemploDelegados.Medios;
using static EjemploDelegados.InventarioMedios;

namespace EjemploDelegados
{

    //Hay que crear una apk para
    //el archivo de medios de una biblioteca publica 
    //de modo que:
    
    //A-Segun el tipo de medio indique al usuario los pasos
    //a dar para reproducir ese medio y verificar
    // si está en buen estado para archivarlo
    // o bien desecharlo si está en mal estado
    
    // B- Crear una apk que permita indicar 
    // los pasos a dar independientemente del medio
    
    //C-Mostrar el contenido del medio según el tipo de medio.
    //Pasar codigo de barras o identificador para localizar el medio
    //en la BBDD
    // CDs-> Mostrar lista de canciones 
    // vinilo -> Mostrar lista de canciones contraportada
    // VHS -> Mostrar información de la pelicula


    internal class Program
    {
        static void Main(string[] args)
        {
           // 1- Crear instancias
           var inventarMedios = new InventarioMedios();

            var tocaDiscos = new Tocadiscos();

            var videoVhs = new VideoVhs();

            var CDs = new ReproductorCds();

            //2- Crear instancias de delegados

            ProbarMediosDelegado probarDiscosDelegado = 
                new ProbarMediosDelegado(tocaDiscos.ProbarVinilos);

            ProbarMediosDelegado probarCinstasVhsDelegado =
                new ProbarMediosDelegado(videoVhs.ProbarVhs);

            ProbarMediosDelegado probarCDsDelegado =
               new ProbarMediosDelegado(CDs.ProbarCd);

            InfoMedioDelegado InfoVinilos =
                new InfoMedioDelegado(tocaDiscos.ObtenerCancionesDisco);



            //3-Utilizar delegados
            inventarMedios.ResultadoProbarMedios(probarDiscosDelegado);

            inventarMedios.ResultadoProbarMedios(probarCinstasVhsDelegado);

            inventarMedios.ResultadoProbarMedios(probarCDsDelegado);

            inventarMedios.ResultadoInfoMedioDelegado(InfoVinilos, "1234");



        }
    }
}