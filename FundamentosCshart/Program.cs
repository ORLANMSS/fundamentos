using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FundamentosCshart.Models;

namespace FundamentosCshart
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            /// Dos maneras de de realizar Arreglos (arreglo siempre va ser mas rapido que una lista)
            for (int i=0; i<numeros.Length; i++)
            {
                Console.WriteLine("interación: " + i + " - " + numeros[i]);
            }

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("*********************************************************");
            List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8};
            ///Se puede agregar muchos elementos
            ///
            lista.Add(9);
            lista.Add(0);
            lista.Remove(2);
            foreach (var numero in lista)
            {
                Console.WriteLine("Elemento: "+numero);
            }
            List<Cerveza> cervezas = new List<Cerveza>() { new Cerveza(10, "Cerveza Premiun") };
            cervezas.Add(new Cerveza(500));
            Cerveza erdinger = new Cerveza(500, "Cerveza de trigo");
            cervezas.Add(erdinger);
            foreach (var cerveza in cervezas)
            {
                Console.WriteLine("Elemento: " + cerveza.Nombre);
            }
        }
    }
}
