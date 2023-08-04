using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Historico
    {
        //Moneda origen
        //Moneda destino
        //Factor conversion
        //Cantidad
        //Resultado
        //Fecha de conversion
        //Usuario

        public Historico()
        {
                
        }

        public Historico(string MonedaOrigenId, string MonedaDestinoId,double FactorConversion, double Cantidad, double Resultado, string FechaConversion)
        {
            this.MonedaOrigenId = MonedaOrigenId;
            this.MonedaDestinoId = MonedaDestinoId;
            this.FactorConversion = FactorConversion;
            this.Cantidad = Cantidad;
            this.Resultado = Resultado;
            this.FechaConversion = FechaConversion;
        }

        public string MonedaOrigenId { get; set; }
        public string MonedaDestinoId { get; set; }
        public double FactorConversion   { get; set; }

        public double Cantidad { get; set; }

        public double Resultado { get; set; }

        public string FechaConversion { get; set; }
    }
}
