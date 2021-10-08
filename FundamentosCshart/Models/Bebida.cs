using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCshart.Models
{
    class Bebida
    {
        public string Nombre { get; set; }

        public int Cantidad { get; set; }


        public Bebida(string Nombre, int Cantidad)
        {
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }

        public void Beberse(int CuantoBebio)
        {
            this.Cantidad -= CuantoBebio;

        }

    }
}
