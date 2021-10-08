using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCshart.Models
{
    class Cerveza : Bebida
    {
        public Cerveza(int Cantidad, string Nombre = "Cerveza")
            : base(Nombre,Cantidad)
        {

        }
    }
}
