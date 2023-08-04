using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factor
    {
        public Factor()
        {
            
        }
        public Factor(string moneda,  double fact)
        {
            Id = moneda;
            Fact = fact;
        }

        public string Id { get; }
        public double Fact { get; set; }
    }
}
